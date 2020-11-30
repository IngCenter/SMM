using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class SignInForm : Form
    {
        public SignInForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.CurrentUser = LoginTB.Text;
            /*
            // Зачем личный кабинет открывать при входе?! (мешает)
            UserForm UserInfo = new UserForm();
            UserInfo.ShowDialog();
            */
            Close();
        }

        private void SignInLLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationForm Registration = new RegistrationForm();
            Registration.Show();
        }
    }
}
