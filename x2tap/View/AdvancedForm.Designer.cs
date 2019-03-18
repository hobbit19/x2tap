namespace x2tap.View
{
    partial class AdvancedForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.v2rayLoggingLevelGroupBox = new System.Windows.Forms.GroupBox();
            this.v2rayLoggingLevelComboBox = new System.Windows.Forms.ComboBox();
            this.v2rayLoggingLevelGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // v2rayLoggingLevelGroupBox
            // 
            this.v2rayLoggingLevelGroupBox.Controls.Add(this.v2rayLoggingLevelComboBox);
            this.v2rayLoggingLevelGroupBox.Location = new System.Drawing.Point(12, 12);
            this.v2rayLoggingLevelGroupBox.Name = "v2rayLoggingLevelGroupBox";
            this.v2rayLoggingLevelGroupBox.Size = new System.Drawing.Size(363, 56);
            this.v2rayLoggingLevelGroupBox.TabIndex = 0;
            this.v2rayLoggingLevelGroupBox.TabStop = false;
            this.v2rayLoggingLevelGroupBox.Text = "v2ray 日志等级";
            // 
            // v2rayLoggingLevelComboBox
            // 
            this.v2rayLoggingLevelComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.v2rayLoggingLevelComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.v2rayLoggingLevelComboBox.FormattingEnabled = true;
            this.v2rayLoggingLevelComboBox.Items.AddRange(new object[] {
            "调试",
            "信息",
            "警告",
            "错误",
            "无"});
            this.v2rayLoggingLevelComboBox.Location = new System.Drawing.Point(6, 22);
            this.v2rayLoggingLevelComboBox.Name = "v2rayLoggingLevelComboBox";
            this.v2rayLoggingLevelComboBox.Size = new System.Drawing.Size(351, 24);
            this.v2rayLoggingLevelComboBox.TabIndex = 0;
            this.v2rayLoggingLevelComboBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ComboBox_DrawItem);
            this.v2rayLoggingLevelComboBox.SelectedIndexChanged += new System.EventHandler(this.v2rayLoggingLevelComboBox_SelectedIndexChanged);
            // 
            // AdvancedForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 79);
            this.Controls.Add(this.v2rayLoggingLevelGroupBox);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "AdvancedForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "高级设置";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdvancedForm_FormClosing);
            this.Load += new System.EventHandler(this.AdvancedForm_Load);
            this.v2rayLoggingLevelGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox v2rayLoggingLevelGroupBox;
        private System.Windows.Forms.ComboBox v2rayLoggingLevelComboBox;
    }
}