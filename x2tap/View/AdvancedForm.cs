using System;
using System.Drawing;
using System.Windows.Forms;

namespace x2tap.View
{
    public partial class AdvancedForm : Form
    {
        public AdvancedForm()
        {
            InitializeComponent();
        }

        private void AdvancedForm_Load(object sender, EventArgs e)
        {
        }

        private void AdvancedForm_FormClosing(object sender, FormClosingEventArgs e)
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

        private void v2rayLoggingLevelComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}