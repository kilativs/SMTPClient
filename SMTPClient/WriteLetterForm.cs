using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMTPClient
{
    public partial class WriteLetterForm : Form
    {

        private static List<string> Att { get; set; } = new();

        private static string[] attach;

        public static WriteLetterForm Instance { get ; set ; }

        public WriteLetterForm()
        {
            InitializeComponent();
            Instance = this;
        }

        private void CanselBt_Click(object sender, EventArgs e)
        {
            Instance.TemsTb.Text = string.Empty;
            Instance.ToTb.Text = string.Empty;
            Instance.NewMessageTb.Text = string.Empty;
            Att.Clear();
            AttCountLbl.Text = string.Empty;
        }

        private async void SendBt_Click(object sender, EventArgs e)
        {
            try
            {
                await SendEmailAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static async Task SendEmailAsync()
        {
            MailMessage message = new();
            message.From = new MailAddress(MailForm.GetInstance().Authorization.MailAddress);
            message.To.Add(new MailAddress(Instance.ToTb.Text));
            message.IsBodyHtml = true;
            message.Body = Instance.NewMessageTb.Text;
            message.Subject = Instance.TemsTb.Text;

            if (Att.Count > 0)
                foreach (string s in Att)
                    message.Attachments.Add(new Attachment(s));

            SmtpClient smtpClient = new(MailForm.GetInstance().Authorization.SMTPHost, MailForm.GetInstance().Authorization.SMTPPort);
            smtpClient.Credentials = new NetworkCredential(MailForm.GetInstance().Authorization.MailAddress, MailForm.GetInstance().Authorization.MailPassword);
            smtpClient.EnableSsl = MailForm.GetInstance().Authorization.MailUseSsl;
            smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
            await Task.Run(() =>
            {
                try
                {
                    smtpClient.Send(message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            });
            MessageBox.Show("Ваше письмо отправлено получателю", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
            Att.Clear();
            Instance.Close();
        }

        private void CloseBn_Click(object sender, EventArgs e) => Instance.Close();

        private void AttachBt_Click(object sender, EventArgs e)
        {
            attach = null;
            openFileDialog1.ShowDialog();
            if (attach != null)
            {
                if ((Att.Count + attach.Length) <= 6)
                {
                    foreach (string s in attach)
                        Att.Add(s);
                    AttCountLbl.ForeColor = Color.RoyalBlue;
                    AttCountLbl.Text = string.Format($"Прикрепленные файлы: {Att.Count} шт.");
                }
                    
                else
                    MessageBox.Show("Максимальное количество прикрепляемых файлов: 6", "Сообщение",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void OpenFileDialog1_FileOk(object sender, CancelEventArgs e) => attach = openFileDialog1.FileNames;

    }
}
