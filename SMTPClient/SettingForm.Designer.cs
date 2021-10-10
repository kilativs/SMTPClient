
namespace SMTPClient
{
    partial class SettingForm
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
            this.AutorizationPanel = new System.Windows.Forms.Panel();
            this.SSLCb = new System.Windows.Forms.CheckBox();
            this.PasswordTb = new System.Windows.Forms.TextBox();
            this.PasswordLbl = new System.Windows.Forms.Label();
            this.LoginTb = new System.Windows.Forms.TextBox();
            this.LoginLbl = new System.Windows.Forms.Label();
            this.SettingPanel = new System.Windows.Forms.Panel();
            this.ConnectBtn = new System.Windows.Forms.Button();
            this.PopPortTb = new System.Windows.Forms.TextBox();
            this.PopPortLbl = new System.Windows.Forms.Label();
            this.PopTb = new System.Windows.Forms.TextBox();
            this.PopLbl = new System.Windows.Forms.Label();
            this.SmtpPortTb = new System.Windows.Forms.TextBox();
            this.PortSmtpLbl = new System.Windows.Forms.Label();
            this.SMTPTb = new System.Windows.Forms.TextBox();
            this.SMTPLbl = new System.Windows.Forms.Label();
            this.LogoPb = new System.Windows.Forms.PictureBox();
            this.AutorizationPanel.SuspendLayout();
            this.SettingPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPb)).BeginInit();
            this.SuspendLayout();
            // 
            // AutorizationPanel
            // 
            this.AutorizationPanel.Controls.Add(this.SSLCb);
            this.AutorizationPanel.Controls.Add(this.PasswordTb);
            this.AutorizationPanel.Controls.Add(this.PasswordLbl);
            this.AutorizationPanel.Controls.Add(this.LoginTb);
            this.AutorizationPanel.Controls.Add(this.LoginLbl);
            this.AutorizationPanel.Location = new System.Drawing.Point(12, 12);
            this.AutorizationPanel.Name = "AutorizationPanel";
            this.AutorizationPanel.Size = new System.Drawing.Size(201, 98);
            this.AutorizationPanel.TabIndex = 0;
            // 
            // SSLCb
            // 
            this.SSLCb.AutoSize = true;
            this.SSLCb.Checked = true;
            this.SSLCb.CheckState = System.Windows.Forms.CheckState.Checked;
            this.SSLCb.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.SSLCb.Location = new System.Drawing.Point(1, 77);
            this.SSLCb.Name = "SSLCb";
            this.SSLCb.Size = new System.Drawing.Size(197, 21);
            this.SSLCb.TabIndex = 4;
            this.SSLCb.Text = " Включить  протокол SSL";
            this.SSLCb.UseVisualStyleBackColor = true;
            // 
            // PasswordTb
            // 
            this.PasswordTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordTb.Location = new System.Drawing.Point(62, 48);
            this.PasswordTb.Name = "PasswordTb";
            this.PasswordTb.PasswordChar = '*';
            this.PasswordTb.PlaceholderText = "Введите пароль";
            this.PasswordTb.Size = new System.Drawing.Size(127, 23);
            this.PasswordTb.TabIndex = 3;
            // 
            // PasswordLbl
            // 
            this.PasswordLbl.AutoSize = true;
            this.PasswordLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.PasswordLbl.Location = new System.Drawing.Point(1, 51);
            this.PasswordLbl.Name = "PasswordLbl";
            this.PasswordLbl.Size = new System.Drawing.Size(64, 17);
            this.PasswordLbl.TabIndex = 2;
            this.PasswordLbl.Text = "Пароль :";
            // 
            // LoginTb
            // 
            this.LoginTb.Location = new System.Drawing.Point(62, 9);
            this.LoginTb.Name = "LoginTb";
            this.LoginTb.PlaceholderText = "Введите логин";
            this.LoginTb.Size = new System.Drawing.Size(127, 23);
            this.LoginTb.TabIndex = 1;
            // 
            // LoginLbl
            // 
            this.LoginLbl.AutoSize = true;
            this.LoginLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.LoginLbl.Location = new System.Drawing.Point(1, 12);
            this.LoginLbl.Name = "LoginLbl";
            this.LoginLbl.Size = new System.Drawing.Size(55, 17);
            this.LoginLbl.TabIndex = 0;
            this.LoginLbl.Text = "Логин :";
            // 
            // SettingPanel
            // 
            this.SettingPanel.Controls.Add(this.ConnectBtn);
            this.SettingPanel.Controls.Add(this.PopPortTb);
            this.SettingPanel.Controls.Add(this.PopPortLbl);
            this.SettingPanel.Controls.Add(this.PopTb);
            this.SettingPanel.Controls.Add(this.PopLbl);
            this.SettingPanel.Controls.Add(this.SmtpPortTb);
            this.SettingPanel.Controls.Add(this.PortSmtpLbl);
            this.SettingPanel.Controls.Add(this.SMTPTb);
            this.SettingPanel.Controls.Add(this.SMTPLbl);
            this.SettingPanel.Location = new System.Drawing.Point(219, 12);
            this.SettingPanel.Name = "SettingPanel";
            this.SettingPanel.Size = new System.Drawing.Size(177, 293);
            this.SettingPanel.TabIndex = 1;
            // 
            // ConnectBtn
            // 
            this.ConnectBtn.Location = new System.Drawing.Point(11, 257);
            this.ConnectBtn.Name = "ConnectBtn";
            this.ConnectBtn.Size = new System.Drawing.Size(157, 23);
            this.ConnectBtn.TabIndex = 8;
            this.ConnectBtn.Text = "Авторизоватся";
            this.ConnectBtn.UseVisualStyleBackColor = true;
            this.ConnectBtn.Click += new System.EventHandler(this.ConnectBtn_Click);
            // 
            // PopPortTb
            // 
            this.PopPortTb.Location = new System.Drawing.Point(60, 201);
            this.PopPortTb.Name = "PopPortTb";
            this.PopPortTb.PlaceholderText = "995";
            this.PopPortTb.Size = new System.Drawing.Size(108, 23);
            this.PopPortTb.TabIndex = 7;
            // 
            // PopPortLbl
            // 
            this.PopPortLbl.AutoSize = true;
            this.PopPortLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.PopPortLbl.Location = new System.Drawing.Point(11, 204);
            this.PopPortLbl.Name = "PopPortLbl";
            this.PopPortLbl.Size = new System.Drawing.Size(41, 17);
            this.PopPortLbl.TabIndex = 6;
            this.PopPortLbl.Text = "Port :";
            // 
            // PopTb
            // 
            this.PopTb.Location = new System.Drawing.Point(60, 152);
            this.PopTb.Name = "PopTb";
            this.PopTb.PlaceholderText = "pop.gmail.com";
            this.PopTb.Size = new System.Drawing.Size(108, 23);
            this.PopTb.TabIndex = 5;
            // 
            // PopLbl
            // 
            this.PopLbl.AutoSize = true;
            this.PopLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.PopLbl.Location = new System.Drawing.Point(11, 155);
            this.PopLbl.Name = "PopLbl";
            this.PopLbl.Size = new System.Drawing.Size(42, 17);
            this.PopLbl.TabIndex = 4;
            this.PopLbl.Text = "POP :";
            // 
            // SmtpPortTb
            // 
            this.SmtpPortTb.Location = new System.Drawing.Point(60, 51);
            this.SmtpPortTb.Name = "SmtpPortTb";
            this.SmtpPortTb.PlaceholderText = "587";
            this.SmtpPortTb.Size = new System.Drawing.Size(108, 23);
            this.SmtpPortTb.TabIndex = 3;
            // 
            // PortSmtpLbl
            // 
            this.PortSmtpLbl.AutoSize = true;
            this.PortSmtpLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.PortSmtpLbl.Location = new System.Drawing.Point(11, 54);
            this.PortSmtpLbl.Name = "PortSmtpLbl";
            this.PortSmtpLbl.Size = new System.Drawing.Size(41, 17);
            this.PortSmtpLbl.TabIndex = 2;
            this.PortSmtpLbl.Text = "Port :";
            // 
            // SMTPTb
            // 
            this.SMTPTb.Location = new System.Drawing.Point(60, 9);
            this.SMTPTb.Name = "SMTPTb";
            this.SMTPTb.PlaceholderText = "smtp.gmail.com";
            this.SMTPTb.Size = new System.Drawing.Size(108, 23);
            this.SMTPTb.TabIndex = 1;
            // 
            // SMTPLbl
            // 
            this.SMTPLbl.AutoSize = true;
            this.SMTPLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.SMTPLbl.Location = new System.Drawing.Point(11, 12);
            this.SMTPLbl.Name = "SMTPLbl";
            this.SMTPLbl.Size = new System.Drawing.Size(50, 17);
            this.SMTPLbl.TabIndex = 0;
            this.SMTPLbl.Text = "SMTP :";
            // 
            // LogoPb
            // 
            this.LogoPb.BackgroundImage = global::SMTPClient.Properties.Resources.iconfinder_email_social_media_online_837799;
            this.LogoPb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LogoPb.Location = new System.Drawing.Point(13, 116);
            this.LogoPb.Name = "LogoPb";
            this.LogoPb.Size = new System.Drawing.Size(199, 189);
            this.LogoPb.TabIndex = 2;
            this.LogoPb.TabStop = false;
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 317);
            this.Controls.Add(this.LogoPb);
            this.Controls.Add(this.SettingPanel);
            this.Controls.Add(this.AutorizationPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "SettingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SettingForm";
            this.AutorizationPanel.ResumeLayout(false);
            this.AutorizationPanel.PerformLayout();
            this.SettingPanel.ResumeLayout(false);
            this.SettingPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPb)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel AutorizationPanel;
        private System.Windows.Forms.TextBox PasswordTb;
        private System.Windows.Forms.Label PasswordLbl;
        private System.Windows.Forms.TextBox LoginTb;
        private System.Windows.Forms.Label LoginLbl;
        private System.Windows.Forms.Panel SettingPanel;
        private System.Windows.Forms.Label PopPortLbl;
        private System.Windows.Forms.Label PopLbl;
        private System.Windows.Forms.Label PortSmtpLbl;
        private System.Windows.Forms.Label SMTPLbl;
        public System.Windows.Forms.Button ConnectBtn;
        public System.Windows.Forms.TextBox PopPortTb;
        public System.Windows.Forms.TextBox PopTb;
        public System.Windows.Forms.TextBox SmtpPortTb;
        public System.Windows.Forms.TextBox SMTPTb;
        private System.Windows.Forms.PictureBox LogoPb;
        public System.Windows.Forms.CheckBox SSLCb;
    }
}