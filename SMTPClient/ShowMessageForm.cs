using OpenPop.Mime;
using System;
using System.Collections;
using System.IO;
using System.Windows.Forms;

namespace SMTPClient
{
    public partial class ShowMessageForm : Form
    {
        public ShowMessageForm()
        {
            InitializeComponent();
            Instance = this;
        }

        public static ShowMessageForm Instance { get; set; }

        private void ClosedBtn_Click(object sender, EventArgs e)
        {
            Instance.Close();
        }

        private async void ShowMessage_Load(object sender, EventArgs e)
        {
            MessageLbl.Text = string.Empty;
            await MailForm.GetInstance().Authorization.LoadMessageAsync(MailForm.GetInstance().MailListLb.SelectedIndex);
        }

        private void SaveFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MailForm.GetInstance().Authorization.dialogres = true;
        }

        private void SaveAttahmentsBtn_Click(object sender, EventArgs e)
        {
            int countOfSavedFiles = 0;

            foreach (var attachment in MailForm.GetInstance().Authorization.Messages[MailForm.GetInstance().Authorization.OpenMailIndex].FindAllAttachments())
            {
                string fileName = attachment.ContentDisposition.FileName;
                saveFileDialog1.FileName = fileName;
                saveFileDialog1.DefaultExt = fileName[fileName.LastIndexOf('.')..];
                MailForm.GetInstance().Authorization.dialogres = false;
                saveFileDialog1.ShowDialog();
                if (MailForm.GetInstance().Authorization.dialogres == true)
                {
                    fileName = saveFileDialog1.FileName;
                    using (var stream = File.Create(fileName))
                    {

                        if (attachment is MessagePart)
                        {
                            var rfc822 = attachment;

                            rfc822.Save(stream);
                        }
                        else
                        {
                            return;
                        }
                    }
                    countOfSavedFiles++;
                }
            }

            if (countOfSavedFiles == MailForm.GetInstance().Authorization.Messages[MailForm.GetInstance().Authorization.OpenMailIndex].FindAllAttachments().Count)
                MessageBox.Show("Все ваши файлы успешно сохранены", "Сообщение", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            else
                MessageBox.Show($"Количество успешно сохраненных файлов: {countOfSavedFiles}", "Сообщение", MessageBoxButtons.OK, 
                    MessageBoxIcon.Information);
        }
    }
}
