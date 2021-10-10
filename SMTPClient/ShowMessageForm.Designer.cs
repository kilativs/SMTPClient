
namespace SMTPClient
{
    partial class ShowMessageForm
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
            this.ShowMessagePanel = new System.Windows.Forms.Panel();
            this.SaveAttahmentsBtn = new System.Windows.Forms.Button();
            this.CountAttahmentsLbl = new System.Windows.Forms.Label();
            this.MessagePanel = new System.Windows.Forms.Panel();
            this.MessageLbl = new System.Windows.Forms.Label();
            this.ClosedBtn = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.ShowMessagePanel.SuspendLayout();
            this.MessagePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ShowMessagePanel
            // 
            this.ShowMessagePanel.Controls.Add(this.SaveAttahmentsBtn);
            this.ShowMessagePanel.Controls.Add(this.CountAttahmentsLbl);
            this.ShowMessagePanel.Controls.Add(this.MessagePanel);
            this.ShowMessagePanel.Controls.Add(this.ClosedBtn);
            this.ShowMessagePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ShowMessagePanel.Location = new System.Drawing.Point(0, 0);
            this.ShowMessagePanel.Name = "ShowMessagePanel";
            this.ShowMessagePanel.Size = new System.Drawing.Size(533, 351);
            this.ShowMessagePanel.TabIndex = 0;
            // 
            // SaveAttahmentsBtn
            // 
            this.SaveAttahmentsBtn.Location = new System.Drawing.Point(192, 322);
            this.SaveAttahmentsBtn.Name = "SaveAttahmentsBtn";
            this.SaveAttahmentsBtn.Size = new System.Drawing.Size(164, 23);
            this.SaveAttahmentsBtn.TabIndex = 4;
            this.SaveAttahmentsBtn.Text = "Сохранить вложения";
            this.SaveAttahmentsBtn.UseVisualStyleBackColor = true;
            this.SaveAttahmentsBtn.Click += new System.EventHandler(this.SaveAttahmentsBtn_Click);
            // 
            // CountAttahmentsLbl
            // 
            this.CountAttahmentsLbl.AutoSize = true;
            this.CountAttahmentsLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CountAttahmentsLbl.Location = new System.Drawing.Point(0, 322);
            this.CountAttahmentsLbl.Name = "CountAttahmentsLbl";
            this.CountAttahmentsLbl.Size = new System.Drawing.Size(0, 17);
            this.CountAttahmentsLbl.TabIndex = 3;
            // 
            // MessagePanel
            // 
            this.MessagePanel.AutoScroll = true;
            this.MessagePanel.Controls.Add(this.MessageLbl);
            this.MessagePanel.Location = new System.Drawing.Point(0, 0);
            this.MessagePanel.Name = "MessagePanel";
            this.MessagePanel.Size = new System.Drawing.Size(533, 316);
            this.MessagePanel.TabIndex = 2;
            // 
            // MessageLbl
            // 
            this.MessageLbl.AutoSize = true;
            this.MessageLbl.Location = new System.Drawing.Point(0, 0);
            this.MessageLbl.Name = "MessageLbl";
            this.MessageLbl.Size = new System.Drawing.Size(0, 15);
            this.MessageLbl.TabIndex = 0;
            // 
            // ClosedBtn
            // 
            this.ClosedBtn.Location = new System.Drawing.Point(372, 322);
            this.ClosedBtn.Name = "ClosedBtn";
            this.ClosedBtn.Size = new System.Drawing.Size(149, 23);
            this.ClosedBtn.TabIndex = 1;
            this.ClosedBtn.Text = "Закрыть";
            this.ClosedBtn.UseVisualStyleBackColor = true;
            this.ClosedBtn.Click += new System.EventHandler(this.ClosedBtn_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.FileName = "saveFileDialog1";
            this.saveFileDialog1.Filter = "All files (*.*)|*.*";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.SaveFileDialog1_FileOk);
            // 
            // ShowMessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 351);
            this.Controls.Add(this.ShowMessagePanel);
            this.Name = "ShowMessageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ShowMessage";
            this.Load += new System.EventHandler(this.ShowMessage_Load);
            this.ShowMessagePanel.ResumeLayout(false);
            this.ShowMessagePanel.PerformLayout();
            this.MessagePanel.ResumeLayout(false);
            this.MessagePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ShowMessagePanel;
        private System.Windows.Forms.Button ClosedBtn;
        private System.Windows.Forms.Panel MessagePanel;
        public System.Windows.Forms.Label MessageLbl;
        public System.Windows.Forms.Button SaveAttahmentsBtn;
        public System.Windows.Forms.Label CountAttahmentsLbl;
        public System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}