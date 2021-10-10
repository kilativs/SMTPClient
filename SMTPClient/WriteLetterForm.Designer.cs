
namespace SMTPClient
{
    partial class WriteLetterForm
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
            this.WritePanel = new System.Windows.Forms.Panel();
            this.CloseBn = new System.Windows.Forms.Button();
            this.SendBt = new System.Windows.Forms.Button();
            this.CanselBt = new System.Windows.Forms.Button();
            this.AttachBt = new System.Windows.Forms.Button();
            this.NewMessageTb = new System.Windows.Forms.TextBox();
            this.NewMessageLbl = new System.Windows.Forms.Label();
            this.TemsTb = new System.Windows.Forms.TextBox();
            this.TemsLbl = new System.Windows.Forms.Label();
            this.ToTb = new System.Windows.Forms.TextBox();
            this.ToLbl = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.AttCountLbl = new System.Windows.Forms.Label();
            this.WritePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // WritePanel
            // 
            this.WritePanel.Controls.Add(this.AttCountLbl);
            this.WritePanel.Controls.Add(this.CloseBn);
            this.WritePanel.Controls.Add(this.SendBt);
            this.WritePanel.Controls.Add(this.CanselBt);
            this.WritePanel.Controls.Add(this.AttachBt);
            this.WritePanel.Controls.Add(this.NewMessageTb);
            this.WritePanel.Controls.Add(this.NewMessageLbl);
            this.WritePanel.Controls.Add(this.TemsTb);
            this.WritePanel.Controls.Add(this.TemsLbl);
            this.WritePanel.Controls.Add(this.ToTb);
            this.WritePanel.Controls.Add(this.ToLbl);
            this.WritePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WritePanel.Location = new System.Drawing.Point(0, 0);
            this.WritePanel.Name = "WritePanel";
            this.WritePanel.Size = new System.Drawing.Size(699, 353);
            this.WritePanel.TabIndex = 0;
            // 
            // CloseBn
            // 
            this.CloseBn.Location = new System.Drawing.Point(587, 316);
            this.CloseBn.Name = "CloseBn";
            this.CloseBn.Size = new System.Drawing.Size(100, 23);
            this.CloseBn.TabIndex = 9;
            this.CloseBn.Text = "Закрыть";
            this.CloseBn.UseVisualStyleBackColor = true;
            this.CloseBn.Click += new System.EventHandler(this.CloseBn_Click);
            // 
            // SendBt
            // 
            this.SendBt.Location = new System.Drawing.Point(336, 318);
            this.SendBt.Name = "SendBt";
            this.SendBt.Size = new System.Drawing.Size(100, 23);
            this.SendBt.TabIndex = 8;
            this.SendBt.Text = "Отправить";
            this.SendBt.UseVisualStyleBackColor = true;
            this.SendBt.Click += new System.EventHandler(this.SendBt_Click);
            // 
            // CanselBt
            // 
            this.CanselBt.Location = new System.Drawing.Point(473, 318);
            this.CanselBt.Name = "CanselBt";
            this.CanselBt.Size = new System.Drawing.Size(91, 23);
            this.CanselBt.TabIndex = 7;
            this.CanselBt.Text = "Отмена";
            this.CanselBt.UseVisualStyleBackColor = true;
            this.CanselBt.Click += new System.EventHandler(this.CanselBt_Click);
            // 
            // AttachBt
            // 
            this.AttachBt.Location = new System.Drawing.Point(13, 318);
            this.AttachBt.Name = "AttachBt";
            this.AttachBt.Size = new System.Drawing.Size(138, 23);
            this.AttachBt.TabIndex = 6;
            this.AttachBt.Text = "Прикрепить файл";
            this.AttachBt.UseVisualStyleBackColor = true;
            this.AttachBt.Click += new System.EventHandler(this.AttachBt_Click);
            // 
            // NewMessageTb
            // 
            this.NewMessageTb.Location = new System.Drawing.Point(118, 93);
            this.NewMessageTb.Multiline = true;
            this.NewMessageTb.Name = "NewMessageTb";
            this.NewMessageTb.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.NewMessageTb.Size = new System.Drawing.Size(569, 190);
            this.NewMessageTb.TabIndex = 5;
            // 
            // NewMessageLbl
            // 
            this.NewMessageLbl.AutoSize = true;
            this.NewMessageLbl.Font = new System.Drawing.Font("Segoe UI", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.NewMessageLbl.Location = new System.Drawing.Point(12, 93);
            this.NewMessageLbl.Name = "NewMessageLbl";
            this.NewMessageLbl.Size = new System.Drawing.Size(110, 20);
            this.NewMessageLbl.TabIndex = 4;
            this.NewMessageLbl.Text = "Сообщение :  ";
            // 
            // TemsTb
            // 
            this.TemsTb.Location = new System.Drawing.Point(118, 51);
            this.TemsTb.Name = "TemsTb";
            this.TemsTb.Size = new System.Drawing.Size(569, 23);
            this.TemsTb.TabIndex = 3;
            // 
            // TemsLbl
            // 
            this.TemsLbl.AutoSize = true;
            this.TemsLbl.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.TemsLbl.Location = new System.Drawing.Point(32, 53);
            this.TemsLbl.Name = "TemsLbl";
            this.TemsLbl.Size = new System.Drawing.Size(64, 21);
            this.TemsLbl.TabIndex = 2;
            this.TemsLbl.Text = "Тема :  ";
            // 
            // ToTb
            // 
            this.ToTb.Location = new System.Drawing.Point(118, 12);
            this.ToTb.Name = "ToTb";
            this.ToTb.Size = new System.Drawing.Size(569, 23);
            this.ToTb.TabIndex = 1;
            // 
            // ToLbl
            // 
            this.ToLbl.AutoSize = true;
            this.ToLbl.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.ToLbl.Location = new System.Drawing.Point(32, 14);
            this.ToLbl.Name = "ToLbl";
            this.ToLbl.Size = new System.Drawing.Size(66, 21);
            this.ToLbl.TabIndex = 0;
            this.ToLbl.Text = "Кому :  ";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.OpenFileDialog1_FileOk);
            // 
            // AttCountLbl
            // 
            this.AttCountLbl.AutoSize = true;
            this.AttCountLbl.Location = new System.Drawing.Point(83, 297);
            this.AttCountLbl.Name = "AttCountLbl";
            this.AttCountLbl.Size = new System.Drawing.Size(0, 15);
            this.AttCountLbl.TabIndex = 10;
            // 
            // WriteLetterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 353);
            this.Controls.Add(this.WritePanel);
            this.Name = "WriteLetterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Write a letter";
            this.WritePanel.ResumeLayout(false);
            this.WritePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel WritePanel;
        public System.Windows.Forms.Button SendBt;
        public System.Windows.Forms.Button CanselBt;
        public System.Windows.Forms.Button AttachBt;
        public System.Windows.Forms.TextBox NewMessageTb;
        public System.Windows.Forms.Label NewMessageLbl;
        public System.Windows.Forms.TextBox TemsTb;
        public System.Windows.Forms.Label TemsLbl;
        public System.Windows.Forms.TextBox ToTb;
        public System.Windows.Forms.Label ToLbl;
        public System.Windows.Forms.Button CloseBn;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label AttCountLbl;
    }
}