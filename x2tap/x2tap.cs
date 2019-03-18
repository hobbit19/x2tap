using System;
using System.Windows.Forms;
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
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(Global.Views.MainForm = new MainForm());
        }
    }
}