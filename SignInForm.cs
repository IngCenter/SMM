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
            string Logged = Program.Select("SELECT COUNT(*) FROM Users" +
                " WHERE Login = '" + LoginTB.Text +
                "' AND Password = '" + PasswordMTB.Text + "'")[0];
            string WrongPass = Program.Select("SELECT COUNT(*) FROM Users" +
                " WHERE Login = '" + LoginTB.Text + "'")[0];
            if (Logged != "0")
            {
                Program.CurrentUser = LoginTB.Text;
                Close();
            }
            else if (WrongPass != "0")
                MessageBox.Show("Неверный пароль");
            else
                MessageBox.Show("Пользователь не зарегистрирован");
        } 

        private void SignInLLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationForm Registration = new RegistrationForm();
            Registration.Show();
        }

        private void SignInForm_Load(object sender, EventArgs e)
        {

        }
    }
}
