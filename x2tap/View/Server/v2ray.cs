using System;
using System.Drawing;
using System.Windows.Forms;

namespace x2tap.View.Server
{
    public partial class v2ray : Form
    {
        /// <summary>
        ///     服务器配置信息索引
        /// </summary>
        public int Index;

        /// <summary>
        ///     窗体工作模式
        /// </summary>
        public bool Mode;

        /// <summary>
        ///     初始化窗体
        /// </summary>
        /// <param name="mode">是否为编辑模式</param>
        /// <param name="index">服务器配置信息索引</param>
        public v2ray(bool mode = false, int index = 0)
        {
            InitializeComponent();

            Mode = mode;
            Index = index;

            if (Mode)
            {
                RemarkTextBox.Text = Global.v2rayProxies[index].Remark;
                AddressTextBox.Text = Global.v2rayProxies[index].Address;
                PortTextBox.Text = Global.v2rayProxies[index].Port.ToString();
                UserIDTextBox.Text = Global.v2rayProxies[index].UserID;
                AlterIDTextBox.Text = Global.v2rayProxies[index].AlterID.ToString();
                TransferProtocolComboBox.SelectedIndex = Global.v2rayProxies[index].TransferProtocol;
                EncryptMethodComboBox.SelectedIndex = Global.v2rayProxies[index].EncryptMethod;
                FakeTypeComboBox.SelectedIndex = Global.v2rayProxies[index].FakeType;
                FakeDomainTextBox.Text = Global.v2rayProxies[index].FakeDomain;
                PathTextBox.Text = Global.v2rayProxies[index].Path;
                TLSSecureCheckBox.Checked = Global.v2rayProxies[index].TLSSecure;
                ControlButton.Text = "保存";
            }
            else
            {
                UserIDTextBox.Text = Guid.NewGuid().ToString();
                TransferProtocolComboBox.SelectedIndex = 0;
                EncryptMethodComboBox.SelectedIndex = 0;
                FakeTypeComboBox.SelectedIndex = 0;
            }
        }

        private void v2ray_Load(object sender, EventArgs e)
        {
        }

        private void v2ray_FormClosing(object sender, FormClosingEventArgs e)
        {
            Global.Views.MainForm.Show();
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

        private void ControlButton_Click(object sender, EventArgs e)
        {
            if (Mode)
            {
                Global.v2rayProxies[Index] = new Objects.Server.v2ray
                {
                    Remark = RemarkTextBox.Text,
                    Address = AddressTextBox.Text,
                    Port = int.Parse(PortTextBox.Text),
                    UserID = UserIDTextBox.Text,
                    AlterID = int.Parse(AlterIDTextBox.Text),
                    TransferProtocol = TransferProtocolComboBox.SelectedIndex,
                    EncryptMethod = EncryptMethodComboBox.SelectedIndex,
                    FakeType = FakeTypeComboBox.SelectedIndex,
                    FakeDomain = FakeDomainTextBox.Text,
                    Path = PathTextBox.Text,
                    TLSSecure = TLSSecureCheckBox.Checked
                };

                MessageBox.Show("保存成功", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Global.v2rayProxies.Add(new Objects.Server.v2ray
                {
                    Remark = RemarkTextBox.Text,
                    Address = AddressTextBox.Text,
                    Port = int.Parse(PortTextBox.Text),
                    UserID = UserIDTextBox.Text,
                    AlterID = int.Parse(AlterIDTextBox.Text),
                    TransferProtocol = TransferProtocolComboBox.SelectedIndex,
                    EncryptMethod = EncryptMethodComboBox.SelectedIndex,
                    FakeType = FakeTypeComboBox.SelectedIndex,
                    FakeDomain = FakeDomainTextBox.Text,
                    Path = PathTextBox.Text,
                    TLSSecure = TLSSecureCheckBox.Checked
                });

                MessageBox.Show("添加成功", "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            Global.Views.MainForm.InitProxies();
            Close();
        }
    }
}