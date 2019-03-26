namespace x2tap.View.Server
{
    partial class Shadowsocks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Shadowsocks));
            this.ShadowsocksConfigurationGroupBox = new System.Windows.Forms.GroupBox();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.PasswordTextBox = new System.Windows.Forms.TextBox();
            this.EncryptMethodComboBox = new System.Windows.Forms.ComboBox();
            this.EncryptMethodLabel = new System.Windows.Forms.Label();
            this.PortTextBox = new System.Windows.Forms.TextBox();
            this.AddressTextBox = new System.Windows.Forms.TextBox();
            this.AddressLabel = new System.Windows.Forms.Label();
            this.RemarkTextBox = new System.Windows.Forms.TextBox();
            this.RemarkLabel = new System.Windows.Forms.Label();
            this.PortLabel = new System.Windows.Forms.Label();
            this.ControlButton = new System.Windows.Forms.Button();
            this.ShadowsocksConfigurationGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // ShadowsocksConfigurationGroupBox
            // 
            this.ShadowsocksConfigurationGroupBox.Controls.Add(this.PasswordLabel);
            this.ShadowsocksConfigurationGroupBox.Controls.Add(this.PasswordTextBox);
            this.ShadowsocksConfigurationGroupBox.Controls.Add(this.EncryptMethodComboBox);
            this.ShadowsocksConfigurationGroupBox.Controls.Add(this.EncryptMethodLabel);
            this.ShadowsocksConfigurationGroupBox.Controls.Add(this.PortTextBox);
            this.ShadowsocksConfigurationGroupBox.Controls.Add(this.AddressTextBox);
            this.ShadowsocksConfigurationGroupBox.Controls.Add(this.AddressLabel);
            this.ShadowsocksConfigurationGroupBox.Controls.Add(this.RemarkTextBox);
            this.ShadowsocksConfigurationGroupBox.Controls.Add(this.RemarkLabel);
            this.ShadowsocksConfigurationGroupBox.Controls.Add(this.PortLabel);
            this.ShadowsocksConfigurationGroupBox.Location = new System.Drawing.Point(12, 12);
            this.ShadowsocksConfigurationGroupBox.Name = "ShadowsocksConfigurationGroupBox";
            this.ShadowsocksConfigurationGroupBox.Size = new System.Drawing.Size(419, 137);
            this.ShadowsocksConfigurationGroupBox.TabIndex = 0;
            this.ShadowsocksConfigurationGroupBox.TabStop = false;
            this.ShadowsocksConfigurationGroupBox.Text = "配置信息";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(9, 109);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(44, 17);
            this.PasswordLabel.TabIndex = 12;
            this.PasswordLabel.Text = "密码：";
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Location = new System.Drawing.Point(69, 106);
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.Size = new System.Drawing.Size(344, 23);
            this.PasswordTextBox.TabIndex = 11;
            this.PasswordTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // EncryptMethodComboBox
            // 
            this.EncryptMethodComboBox.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.EncryptMethodComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EncryptMethodComboBox.FormattingEnabled = true;
            this.EncryptMethodComboBox.Items.AddRange(new object[] {
            "AES-256-CFB",
            "AES-128-CFB",
            "CHACHA20",
            "CHACHA20-IETF",
            "AES-256-GCM",
            "AES-128-GCM",
            "CHACHA20-POLY1305"});
            this.EncryptMethodComboBox.Location = new System.Drawing.Point(69, 76);
            this.EncryptMethodComboBox.Name = "EncryptMethodComboBox";
            this.EncryptMethodComboBox.Size = new System.Drawing.Size(344, 24);
            this.EncryptMethodComboBox.TabIndex = 10;
            this.EncryptMethodComboBox.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ComboBox_DrawItem);
            // 
            // EncryptMethodLabel
            // 
            this.EncryptMethodLabel.AutoSize = true;
            this.EncryptMethodLabel.Location = new System.Drawing.Point(8, 80);
            this.EncryptMethodLabel.Name = "EncryptMethodLabel";
            this.EncryptMethodLabel.Size = new System.Drawing.Size(68, 17);
            this.EncryptMethodLabel.TabIndex = 9;
            this.EncryptMethodLabel.Text = "加密方式：";
            // 
            // PortTextBox
            // 
            this.PortTextBox.Location = new System.Drawing.Point(357, 48);
            this.PortTextBox.Name = "PortTextBox";
            this.PortTextBox.Size = new System.Drawing.Size(56, 23);
            this.PortTextBox.TabIndex = 8;
            this.PortTextBox.Text = "443";
            this.PortTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AddressTextBox
            // 
            this.AddressTextBox.Location = new System.Drawing.Point(69, 48);
            this.AddressTextBox.Name = "AddressTextBox";
            this.AddressTextBox.Size = new System.Drawing.Size(283, 23);
            this.AddressTextBox.TabIndex = 3;
            this.AddressTextBox.Text = "www.baidu.com";
            this.AddressTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // AddressLabel
            // 
            this.AddressLabel.AutoSize = true;
            this.AddressLabel.Location = new System.Drawing.Point(8, 51);
            this.AddressLabel.Name = "AddressLabel";
            this.AddressLabel.Size = new System.Drawing.Size(44, 17);
            this.AddressLabel.TabIndex = 2;
            this.AddressLabel.Text = "地址：";
            // 
            // RemarkTextBox
            // 
            this.RemarkTextBox.Location = new System.Drawing.Point(69, 19);
            this.RemarkTextBox.Name = "RemarkTextBox";
            this.RemarkTextBox.Size = new System.Drawing.Size(344, 23);
            this.RemarkTextBox.TabIndex = 1;
            this.RemarkTextBox.Text = "百度为您提供强力加速";
            this.RemarkTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // RemarkLabel
            // 
            this.RemarkLabel.AutoSize = true;
            this.RemarkLabel.Location = new System.Drawing.Point(8, 22);
            this.RemarkLabel.Name = "RemarkLabel";
            this.RemarkLabel.Size = new System.Drawing.Size(44, 17);
            this.RemarkLabel.TabIndex = 0;
            this.RemarkLabel.Text = "备注：";
            // 
            // PortLabel
            // 
            this.PortLabel.AutoSize = true;
            this.PortLabel.Location = new System.Drawing.Point(350, 51);
            this.PortLabel.Name = "PortLabel";
            this.PortLabel.Size = new System.Drawing.Size(11, 17);
            this.PortLabel.TabIndex = 7;
            this.PortLabel.Text = ":";
            // 
            // ControlButton
            // 
            this.ControlButton.Location = new System.Drawing.Point(356, 155);
            this.ControlButton.Name = "ControlButton";
            this.ControlButton.Size = new System.Drawing.Size(75, 23);
            this.ControlButton.TabIndex = 2;
            this.ControlButton.Text = "添加";
            this.ControlButton.UseVisualStyleBackColor = true;
            this.ControlButton.Click += new System.EventHandler(this.ControlButton_Click);
            // 
            // Shadowsocks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 188);
            this.Controls.Add(this.ControlButton);
            this.Controls.Add(this.ShadowsocksConfigurationGroupBox);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Shadowsocks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shadowsocks";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Shadowsocks_FormClosing);
            this.Load += new System.EventHandler(this.Shadowsocks_Load);
            this.ShadowsocksConfigurationGroupBox.ResumeLayout(false);
            this.ShadowsocksConfigurationGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ShadowsocksConfigurationGroupBox;
        private System.Windows.Forms.Label RemarkLabel;
        private System.Windows.Forms.TextBox AddressTextBox;
        private System.Windows.Forms.Label AddressLabel;
        private System.Windows.Forms.TextBox RemarkTextBox;
        private System.Windows.Forms.TextBox PortTextBox;
        private System.Windows.Forms.Label PortLabel;
        private System.Windows.Forms.ComboBox EncryptMethodComboBox;
        private System.Windows.Forms.Label EncryptMethodLabel;
        private System.Windows.Forms.Button ControlButton;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.TextBox PasswordTextBox;
    }
}