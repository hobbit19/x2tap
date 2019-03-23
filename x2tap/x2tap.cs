using System;
using System.Windows.Forms;
using x2tap.Utils;
using x2tap.View;

namespace x2tap
{
    public static class x2tap
    {
        /// <summary>
        ///     应用程序的主入口点
        /// </summary>
        [STAThread]
        public static void Main()
        {
            // 检查 TUN/TAP 适配器
            if (TUNTAP.GetComponentId() == "")
            {
                MessageBox.Show("未检测到 TUN/TAP 适配器，请检查 TAP-Windows 是否正确安装！", "警告", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                Application.Exit();
                return;
            }

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(Global.Views.MainForm = new MainForm());
        }
    }
}