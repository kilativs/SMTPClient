using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace SMTPClient
{
    public partial class SettingForm : Form
    {
        private static SettingForm _instance;

        private SettingForm()
        {
            InitializeComponent();
        }

        public static SettingForm GetInstance() => _instance ??= new SettingForm();

        private void ConnectBtn_Click(object sender, EventArgs e)
        {
            MailForm.GetInstance().MailListLb.Items.Clear();
            if(IsValidEmail(LoginTb.Text))
            {
                MailForm.GetInstance().Authorization = new Authorization(LoginTb.Text, PasswordTb.Text)
                {
                    POPHost = GetPopHost(),
                    PopPort = GetPopPort(),

                    SMTPHost = GetSmtpHost(),
                    SMTPPort = GetSmtpPort()
                };

                _instance.DialogResult = DialogResult.OK;
                _instance.Hide();
                MailForm.GetInstance().WriteBtn.Enabled = true;
            }
            else
            {
                MessageBox.Show("Неверно введён email-адресс", "Ошибка!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string GetPopHost()
        {
            string tempHost;
            if (PopTb.TextLength !=0)
            {
                 tempHost = PopTb.Text;
            }
            else
            {
                tempHost = "pop.gmail.com";
            }
            return tempHost;
        }

        private string GetSmtpHost()
        {
            string tempSmtpHost;
            if (SMTPTb.TextLength != 0)
            {
                tempSmtpHost = SMTPTb.Text;
            }
            else
            {
                tempSmtpHost = "smtp.gmail.com";
            }
            return tempSmtpHost;
        }

        private ushort GetPopPort()
        {
            ushort tempPort;
            if (PopPortTb.TextLength != 0)
            {
                 tempPort = ushort.Parse(PopPortTb.Text);
            }
            else
            {
                tempPort = 995;
            }
            return tempPort;
        }

        private ushort GetSmtpPort()
        {
            ushort tempSmtpPort;
            if (SmtpPortTb.TextLength != 0)
            {
                tempSmtpPort = ushort.Parse(SmtpPortTb.Text);
            }
            else
            {
                tempSmtpPort = 587;
            }
            return tempSmtpPort;
        }

        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));

                static string DomainMapper(Match match)
                {
                    var idn = new IdnMapping();

                    string domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
            catch (ArgumentException)
            {
                return false;
            }
            try
            {
                return Regex.IsMatch(email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }
    }
}
