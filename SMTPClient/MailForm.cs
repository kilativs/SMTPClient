using System;
using System.Windows.Forms;

namespace SMTPClient
{
    public partial class MailForm : Form
    {
        private static MailForm _instance;

        public Authorization Authorization { get; set; }

        private MailForm()
        {
            InitializeComponent();
        }

        public static MailForm GetInstance() => _instance ??= new MailForm();

        private async void SettingBtn_Click(object sender, EventArgs e)
        {
            var res = SettingForm.GetInstance().ShowDialog();
            if(res == DialogResult.OK)
            {
               await Authorization.LoginAsync();
               await Authorization.GetMessagesAsync();
            }
        }

        private void MailListLb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (MailListLb.SelectedIndex == -1) return;

            var res = new ShowMessageForm();
            res.ShowDialog();
        }

        private void WriteBtn_Click(object sender, EventArgs e)
        {
            var res = new WriteLetterForm();
            res.ShowDialog();
        }

        private void MailForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (Authorization is null) return;
            Authorization.MailClient.Disconnect();
        }
    }
}
