using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using x2tap.Override;
using x2tap.Utils;

namespace x2tap.View
{
    public partial class SubscribeForm : Form
    {
        public SubscribeForm()
        {
            InitializeComponent();
        }

        private void SubscribeForm_Load(object sender, EventArgs e)
        {
        }

        private void SubscribeForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Global.Views.MainForm.Show();
        }

        private void SubscribeURLButton_Click(object sender, EventArgs e)
        {
            using (var client = new WebClient())
            {
                var response = client.DownloadString(SubscribeURLTextBox.Text);
                if (response != "")
                {
                    if (response.Length % 4 != 0)
                    {
                        for (var i = 0; i < response.Length % 4; i++)
                        {
                            response += "=";
                        }
                    }

                    response = Encoding.UTF8.GetString(Convert.FromBase64String(response));

                    Global.v2rayProxies.Clear();
                    Global.ShadowsocksProxies.Clear();

                    using (var sr = new StringReader(response))
                    {
                        var i = 0;
                        string text;

                        while ((text = sr.ReadLine()) != null)
                        {
                            i++;

                            if (text.StartsWith("vmess://"))
                            {
                                Global.v2rayProxies.Add(Parse.v2ray(text));
                            }
                            else if (text.StartsWith("ss://"))
                            {
                                Global.ShadowsocksProxies.Add(Parse.Shadowsocks(text));
                            }
                            else
                            {
                                throw new Exception(string.Format("无法解析的地址：{0}", text));
                            }
                        }

                        MessageBox.Show(string.Format("成功导入 {0} 条代理", i), "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("订阅链接返回内容为空", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SubscribeTextButton_Click(object sender, EventArgs e)
        {
            if (SubscribeTextTextBox.Text != "")
            {
                Global.v2rayProxies.Clear();
                Global.ShadowsocksProxies.Clear();

                using (var sr = new StringReader(SubscribeTextTextBox.Text))
                {
                    var i = 0;
                    string text;

                    while ((text = sr.ReadLine()) != null)
                    {
                        i++;

                        if (text.StartsWith("vmess://"))
                        {
                            Global.v2rayProxies.Add(Parse.v2ray(text));
                        }
                        else if (text.StartsWith("ss://"))
                        {
                            Global.ShadowsocksProxies.Add(Parse.Shadowsocks(text));
                        }
                        else
                        {
                            throw new Exception(string.Format("无法解析的地址：{0}", text));
                        }
                    }

                    MessageBox.Show(string.Format("成功导入 {0} 条代理", i), "信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("文本为空", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}