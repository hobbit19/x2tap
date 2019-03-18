namespace x2tap.View
{
    partial class SubscribeForm
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
            this.SubscribeURLGroupBox = new System.Windows.Forms.GroupBox();
            this.SubscribeURLButton = new System.Windows.Forms.Button();
            this.SubscribeURLTextBox = new System.Windows.Forms.TextBox();
            this.SubscribeTextGroupBox = new System.Windows.Forms.GroupBox();
            this.SubscribeTextButton = new System.Windows.Forms.Button();
            this.SubscribeTextTextBox = new System.Windows.Forms.TextBox();
            this.SubscribeURLGroupBox.SuspendLayout();
            this.SubscribeTextGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // SubscribeURLGroupBox
            // 
            this.SubscribeURLGroupBox.Controls.Add(this.SubscribeURLButton);
            this.SubscribeURLGroupBox.Controls.Add(this.SubscribeURLTextBox);
            this.SubscribeURLGroupBox.Location = new System.Drawing.Point(12, 12);
            this.SubscribeURLGroupBox.Name = "SubscribeURLGroupBox";
            this.SubscribeURLGroupBox.Size = new System.Drawing.Size(661, 80);
            this.SubscribeURLGroupBox.TabIndex = 0;
            this.SubscribeURLGroupBox.TabStop = false;
            this.SubscribeURLGroupBox.Text = "从订阅链接";
            // 
            // SubscribeURLButton
            // 
            this.SubscribeURLButton.Location = new System.Drawing.Point(580, 51);
            this.SubscribeURLButton.Name = "SubscribeURLButton";
            this.SubscribeURLButton.Size = new System.Drawing.Size(75, 23);
            this.SubscribeURLButton.TabIndex = 1;
            this.SubscribeURLButton.Text = "订阅";
            this.SubscribeURLButton.UseVisualStyleBackColor = true;
            this.SubscribeURLButton.Click += new System.EventHandler(this.SubscribeURLButton_Click);
            // 
            // SubscribeURLTextBox
            // 
            this.SubscribeURLTextBox.Location = new System.Drawing.Point(6, 22);
            this.SubscribeURLTextBox.Name = "SubscribeURLTextBox";
            this.SubscribeURLTextBox.Size = new System.Drawing.Size(649, 23);
            this.SubscribeURLTextBox.TabIndex = 0;
            // 
            // SubscribeTextGroupBox
            // 
            this.SubscribeTextGroupBox.Controls.Add(this.SubscribeTextButton);
            this.SubscribeTextGroupBox.Controls.Add(this.SubscribeTextTextBox);
            this.SubscribeTextGroupBox.Location = new System.Drawing.Point(12, 98);
            this.SubscribeTextGroupBox.Name = "SubscribeTextGroupBox";
            this.SubscribeTextGroupBox.Size = new System.Drawing.Size(661, 277);
            this.SubscribeTextGroupBox.TabIndex = 1;
            this.SubscribeTextGroupBox.TabStop = false;
            this.SubscribeTextGroupBox.Text = "从文本";
            // 
            // SubscribeTextButton
            // 
            this.SubscribeTextButton.Location = new System.Drawing.Point(580, 248);
            this.SubscribeTextButton.Name = "SubscribeTextButton";
            this.SubscribeTextButton.Size = new System.Drawing.Size(75, 23);
            this.SubscribeTextButton.TabIndex = 1;
            this.SubscribeTextButton.Text = "订阅";
            this.SubscribeTextButton.UseVisualStyleBackColor = true;
            this.SubscribeTextButton.Click += new System.EventHandler(this.SubscribeTextButton_Click);
            // 
            // SubscribeTextTextBox
            // 
            this.SubscribeTextTextBox.Location = new System.Drawing.Point(6, 22);
            this.SubscribeTextTextBox.Multiline = true;
            this.SubscribeTextTextBox.Name = "SubscribeTextTextBox";
            this.SubscribeTextTextBox.Size = new System.Drawing.Size(649, 220);
            this.SubscribeTextTextBox.TabIndex = 0;
            // 
            // SubscribeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 387);
            this.Controls.Add(this.SubscribeTextGroupBox);
            this.Controls.Add(this.SubscribeURLGroupBox);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "SubscribeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "订阅";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.SubscribeForm_FormClosing);
            this.Load += new System.EventHandler(this.SubscribeForm_Load);
            this.SubscribeURLGroupBox.ResumeLayout(false);
            this.SubscribeURLGroupBox.PerformLayout();
            this.SubscribeTextGroupBox.ResumeLayout(false);
            this.SubscribeTextGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox SubscribeURLGroupBox;
        private System.Windows.Forms.Button SubscribeURLButton;
        private System.Windows.Forms.TextBox SubscribeURLTextBox;
        private System.Windows.Forms.GroupBox SubscribeTextGroupBox;
        private System.Windows.Forms.Button SubscribeTextButton;
        private System.Windows.Forms.TextBox SubscribeTextTextBox;
    }
}