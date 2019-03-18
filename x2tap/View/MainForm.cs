using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Grpc.Core;
using v2ray.Core.App.Stats.Command;
using x2tap.Objects.Server;
using x2tap.Utils;

namespace x2tap.View
{
    public partial class MainForm : Form
    {
        /// <summary>
        ///     流量
        /// </summary>
        public long Bandwidth;

        /// <summary>
        ///     启动状态
        /// </summary>
        public bool Started;

        /// <summary>
        ///     装填信息
        /// </summary>
        public string Status = "请下达命令！";

        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        ///     初始化代理
        /// </summary>
        public void InitProxies()
        {
            ProxyComboBox.Items.Clear();
            foreach (var v2ray in Global.v2rayProxies) ProxyComboBox.Items.Add(string.Format("[v2ray] {0}", v2ray.Remark));
            foreach (var shadowsocks in Global.ShadowsocksProxies) ProxyComboBox.Items.Add(string.Format("[Shadowsocks] {0}", shadowsocks.Remark));
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (TUNTAP.GetComponentId() == "") MessageBox.Show("未检测到 TUN/TAP 适配器，请检查 TAP-Windows 是否正确安装！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            Global.v2rayProxies.Add(new Objects.Server.v2ray
            {
                Remark = "百度为您提供强力加速 1234"
            });

            Global.ShadowsocksProxies.Add(new Shadowsocks
            {
                Remark = "百度为您提供强力加速 1234"
            });

            // 初始化代理
            InitProxies();
            if (ProxyComboBox.Items.Count > 0) ProxyComboBox.SelectedIndex = 0;

            // 初始化模式
            ModeComboBox.SelectedIndex = 0;

            // 后台工作
            Task.Run(() =>
            {
                while (true)
                {
                    try
                    {
                        // 更新标题栏时间
                        Invoke(new MethodInvoker(() => { Text = string.Format("x2tap - {0}", DateTime.Now.ToString()); }));

                        // 更新状态信息
                        StatusStrip.Invoke(new MethodInvoker(() => { StatusLabel.Text = string.Format("状态：{0}", Status); }));

                        // 更新流量信息
                        if (Started)
                        {
                            // 创建客户端实例
                            var client = new StatsService.StatsServiceClient(new Channel("127.0.0.1:2811", ChannelCredentials.Insecure));

                            // 获取并重置 上行/下行 统计信息
                            var uplink = client.GetStats(new GetStatsRequest {Name = "inbound>>>defaultInbound>>>traffic>>>uplink", Reset = true});
                            var downlink = client.GetStats(new GetStatsRequest {Name = "inbound>>>defaultInbound>>>traffic>>>downlink", Reset = true});

                            // 加入总流量
                            Bandwidth += uplink.Stat.Value;
                            Bandwidth += downlink.Stat.Value;

                            // 更新流量信息
                            StatusStrip.Invoke(new MethodInvoker(() =>
                            {
                                UsedBandwidthLabel.Text = string.Format("已使用：{0}", Util.ComputeBandwidth(Bandwidth));
                                UplinkSpeedLabel.Text = string.Format("↑：{0}/s", Util.ComputeBandwidth(uplink.Stat.Value));
                                DownlinkSpeedLabel.Text = string.Format("↓：{0}/s", Util.ComputeBandwidth(downlink.Stat.Value));
                            }));
                        }
                        else
                        {
                            UsedBandwidthLabel.Text = "已使用：0 KB";
                            UplinkSpeedLabel.Text = "↑：0 KB/s";
                            DownlinkSpeedLabel.Text = "↓：0 KB/s";
                        }
                    }
                    catch (Exception)
                    {
                    }

                    // 休眠 100 毫秒
                    Thread.Sleep(100);
                }
            });
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Started)
            {
                e.Cancel = true;

                MessageBox.Show("请先点击关闭按钮", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ComboBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            var cbx = sender as ComboBox;
            if (cbx != null)
            {
                e.DrawBackground();

                if (e.Index >= 0)
                {
                    var sf = new StringFormat();
                    sf.LineAlignment = StringAlignment.Center;
                    sf.Alignment = StringAlignment.Center;

                    var brush = new SolidBrush(cbx.ForeColor);

                    if ((e.State & DrawItemState.Selected) == DrawItemState.Selected) brush = SystemBrushes.HighlightText as SolidBrush;

                    e.Graphics.DrawString(cbx.Items[e.Index].ToString(), cbx.Font, brush, e.Bounds, sf);
                }
            }
        }

        private void Addv2rayServerButton_Click(object sender, EventArgs e)
        {
            (Global.Views.Server.v2ray = new Server.v2ray()).Show();
            Hide();
        }

        private void AddShadowsocksButton_Click(object sender, EventArgs e)
        {
            (Global.Views.Server.Shadowsocks = new Server.Shadowsocks()).Show();
            Hide();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            var index = ProxyComboBox.SelectedIndex;
            if (index != -1)
            {
                ProxyComboBox.Items.RemoveAt(index);

                if (index < Global.v2rayProxies.Count)
                    Global.v2rayProxies.RemoveAt(index);
                else
                    Global.ShadowsocksProxies.RemoveAt(index - Global.v2rayProxies.Count);

                if (ProxyComboBox.Items.Count < index)
                    ProxyComboBox.SelectedIndex = index;
                else if (ProxyComboBox.Items.Count == 1)
                    ProxyComboBox.SelectedIndex = 0;
                else
                    ProxyComboBox.SelectedIndex = index - 1;
            }
            else
            {
                MessageBox.Show("请选择一个代理", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (ProxyComboBox.SelectedIndex != -1)
            {
                if (ProxyComboBox.SelectedIndex < Global.v2rayProxies.Count)
                    (Global.Views.Server.v2ray = new Server.v2ray(true, ProxyComboBox.SelectedIndex)).Show();
                else
                    (Global.Views.Server.Shadowsocks = new Server.Shadowsocks(true, ProxyComboBox.SelectedIndex - Global.v2rayProxies.Count)).Show();

                Hide();
            }
            else
            {
                MessageBox.Show("请选择一个代理", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void SubscribeButton_Click(object sender, EventArgs e)
        {
            (Global.Views.SubscribeForm = new SubscribeForm()).Show();
            Hide();
        }

        private void AdvancedButton_Click(object sender, EventArgs e)
        {
            (Global.Views.AdvancedForm = new AdvancedForm()).Show();
            Hide();
        }

        private void ControlButton_Click(object sender, EventArgs e)
        {
            if (!Started)
            {
                ControlButton.Text = "执行中";
                ControlButton.Enabled = false;

                Task.Run(() =>
                {
                    Status = "正在生成配置文件中";

                    Thread.Sleep(1000);
                    Started = true;
                    ControlButton.Invoke(new MethodInvoker(() =>
                    {
                        ControlButton.Text = "停止";
                        ControlButton.Enabled = true;
                    }));
                });
            }
            else
            {
                ControlButton.Text = "执行中";
                ControlButton.Enabled = false;

                Task.Run(() =>
                {
                    Status = "已停止";

                    Thread.Sleep(1000);
                    Started = false;
                    ControlButton.Invoke(new MethodInvoker(() =>
                    {
                        ControlButton.Text = "启动";
                        ControlButton.Enabled = true;
                    }));
                });
            }
        }

        private void ProjectLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Shell.ExecuteCommandNoWait("start", "https://github.com/hacking001/x2tap");
        }
    }
}