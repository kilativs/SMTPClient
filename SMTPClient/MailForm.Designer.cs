
namespace SMTPClient
{
    partial class MailForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.HeaderLbl = new System.Windows.Forms.Label();
            this.MailPanel = new System.Windows.Forms.Panel();
            this.MailListLb = new System.Windows.Forms.ListBox();
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.CountMessageLbl = new System.Windows.Forms.Label();
            this.IncomingLbl = new System.Windows.Forms.Label();
            this.SettingBtn = new System.Windows.Forms.Button();
            this.WriteBtn = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.panel1.SuspendLayout();
            this.HeaderPanel.SuspendLayout();
            this.MailPanel.SuspendLayout();
            this.MenuPanel.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.HeaderPanel);
            this.panel1.Controls.Add(this.MailPanel);
            this.panel1.Controls.Add(this.MenuPanel);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(964, 387);
            this.panel1.TabIndex = 0;
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.HeaderPanel.Controls.Add(this.HeaderLbl);
            this.HeaderPanel.Location = new System.Drawing.Point(4, -3);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(957, 63);
            this.HeaderPanel.TabIndex = 2;
            // 
            // HeaderLbl
            // 
            this.HeaderLbl.AutoSize = true;
            this.HeaderLbl.Font = new System.Drawing.Font("Yu Gothic UI", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.HeaderLbl.Location = new System.Drawing.Point(230, 9);
            this.HeaderLbl.Name = "HeaderLbl";
            this.HeaderLbl.Size = new System.Drawing.Size(331, 50);
            this.HeaderLbl.TabIndex = 0;
            this.HeaderLbl.Text = "Почтовый клиент";
            this.HeaderLbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MailPanel
            // 
            this.MailPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MailPanel.AutoSize = true;
            this.MailPanel.Controls.Add(this.MailListLb);
            this.MailPanel.Location = new System.Drawing.Point(222, 59);
            this.MailPanel.Name = "MailPanel";
            this.MailPanel.Size = new System.Drawing.Size(739, 322);
            this.MailPanel.TabIndex = 1;
            // 
            // MailListLb
            // 
            this.MailListLb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MailListLb.FormattingEnabled = true;
            this.MailListLb.HorizontalScrollbar = true;
            this.MailListLb.ItemHeight = 15;
            this.MailListLb.Location = new System.Drawing.Point(0, 0);
            this.MailListLb.Name = "MailListLb";
            this.MailListLb.Size = new System.Drawing.Size(739, 322);
            this.MailListLb.TabIndex = 0;
            this.MailListLb.SelectedIndexChanged += new System.EventHandler(this.MailListLb_SelectedIndexChanged);
            // 
            // MenuPanel
            // 
            this.MenuPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.MenuPanel.Controls.Add(this.CountMessageLbl);
            this.MenuPanel.Controls.Add(this.IncomingLbl);
            this.MenuPanel.Controls.Add(this.SettingBtn);
            this.MenuPanel.Controls.Add(this.WriteBtn);
            this.MenuPanel.Location = new System.Drawing.Point(4, 59);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(212, 322);
            this.MenuPanel.TabIndex = 0;
            // 
            // CountMessageLbl
            // 
            this.CountMessageLbl.AutoSize = true;
            this.CountMessageLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CountMessageLbl.ForeColor = System.Drawing.Color.Blue;
            this.CountMessageLbl.Location = new System.Drawing.Point(176, 17);
            this.CountMessageLbl.Name = "CountMessageLbl";
            this.CountMessageLbl.Size = new System.Drawing.Size(0, 21);
            this.CountMessageLbl.TabIndex = 5;
            // 
            // IncomingLbl
            // 
            this.IncomingLbl.AutoSize = true;
            this.IncomingLbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IncomingLbl.Location = new System.Drawing.Point(12, 17);
            this.IncomingLbl.Name = "IncomingLbl";
            this.IncomingLbl.Size = new System.Drawing.Size(170, 20);
            this.IncomingLbl.TabIndex = 4;
            this.IncomingLbl.Text = "Входящие сообщения: ";
            // 
            // SettingBtn
            // 
            this.SettingBtn.Location = new System.Drawing.Point(12, 257);
            this.SettingBtn.Name = "SettingBtn";
            this.SettingBtn.Size = new System.Drawing.Size(164, 44);
            this.SettingBtn.TabIndex = 3;
            this.SettingBtn.Text = "Настройки";
            this.SettingBtn.UseVisualStyleBackColor = true;
            this.SettingBtn.Click += new System.EventHandler(this.SettingBtn_Click);
            // 
            // WriteBtn
            // 
            this.WriteBtn.Enabled = false;
            this.WriteBtn.Location = new System.Drawing.Point(12, 87);
            this.WriteBtn.Name = "WriteBtn";
            this.WriteBtn.Size = new System.Drawing.Size(164, 48);
            this.WriteBtn.TabIndex = 2;
            this.WriteBtn.Text = "Написать письмо";
            this.WriteBtn.UseVisualStyleBackColor = true;
            this.WriteBtn.Click += new System.EventHandler(this.WriteBtn_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 72);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(192, 72);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(685, 34);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(200, 100);
            this.tabControl1.TabIndex = 1;
            // 
            // MailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 387);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "MailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mail Client";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MailForm_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.HeaderPanel.ResumeLayout(false);
            this.HeaderPanel.PerformLayout();
            this.MailPanel.ResumeLayout(false);
            this.MenuPanel.ResumeLayout(false);
            this.MenuPanel.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel MailPanel;
        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Panel HeaderPanel;
        private System.Windows.Forms.Label HeaderLbl;
        private System.Windows.Forms.Button SettingBtn;
        public System.Windows.Forms.ListBox MailListLb;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        public System.Windows.Forms.Label CountMessageLbl;
        public System.Windows.Forms.Label IncomingLbl;
        public System.Windows.Forms.Button WriteBtn;
    }
}

