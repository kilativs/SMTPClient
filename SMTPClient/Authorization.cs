using OpenPop.Pop3;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SMTPClient
{
    public class Authorization
    {
        public string SMTPHost { get; set; }
        public ushort SMTPPort { get; set; }

        public string POPHost { get; set; }
        public ushort PopPort { get; set; }

        public bool MailUseSsl  { get; set; }

        public string MailAddress { get; set; }

        public string MailPassword { get; set; }

        public Pop3Client MailClient { get; set; } = new Pop3Client();

        public List<OpenPop.Mime.Message> Messages { get; set; } = new();

        public List<string> Att { get; set; } = new();

        public string[] attach;

        public int OpenMailIndex { get; set; } = 0;

        public bool dialogres = false;

        public Authorization(string mail, string password)
        {
            MailAddress = mail;
            MailPassword = password;
        }

        public async Task LoginAsync()
        {
            await Task.Run(() =>
            {
                if (SettingForm.GetInstance().SSLCb.CheckState == CheckState.Checked)
                {
                    MailForm.GetInstance().Authorization.MailUseSsl = true;
                }
                if (SettingForm.GetInstance().SSLCb.CheckState == CheckState.Unchecked)
                {
                    MailForm.GetInstance().Authorization.MailUseSsl = false;
                }
                try
                {
                    MailClient.Connect(POPHost, PopPort, MailUseSsl);
                    MailClient.Authenticate(MailAddress, MailPassword);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message,"Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            });
        }

        public async Task GetMessagesAsync()
        {
            await Task.Run(() => 
            {
                try
                {
                    var count = MailClient.GetMessageCount();

                    MailForm.GetInstance().IncomingLbl.ForeColor = System.Drawing.Color.Blue;
                    MailForm.GetInstance().CountMessageLbl.Invoke(new Action(() =>
                    {
                        MailForm.GetInstance().CountMessageLbl.Text = count.ToString();
                    }));

                    for (var i = count; i > 0; i--)
                    {
                        var message = MailClient.GetMessage(i);
                        var fromStr = $"[{message.Headers.DateSent}]  {message.Headers.From.MailAddress} |" +
                                      $" { message.Headers.Subject}";

                        Messages.Add(message);

                        MailForm.GetInstance().MailListLb.Invoke(new Action(() =>
                        {
                            MailForm.GetInstance().MailListLb.Items.Add(fromStr);
                        }));
                    }
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            });
        }

        public async Task LoadMessageAsync(int index)
        {
            await Task.Run(() =>
            {
            try
            {
                var msg = Messages[index];

                    ShowMessageForm.Instance.MessageLbl.Invoke(new Action(() =>
                    {
                        var str = Encoding.Default.GetString(msg.FindFirstPlainTextVersion().Body);
                        ShowMessageForm.Instance.MessageLbl.Text = str;
                    }));

               var mailAttachments = Messages[index].FindAllAttachments();
                    if (mailAttachments.Count > 0)
                    {
                        ShowMessageForm.Instance.CountAttahmentsLbl.ForeColor = System.Drawing.Color.DarkGreen;
                        ShowMessageForm.Instance.CountAttahmentsLbl.Invoke(new Action(() =>
                        {
                            ShowMessageForm.Instance.CountAttahmentsLbl.Text = $"Прикрепленные файлы: {mailAttachments.Count} шт.";
                        }));
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            });
        }
    }
}
