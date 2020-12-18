using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

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
/*            if (
                Convert.ToInt32(
                    Program.Select(
                        "SELECT COUNT(*) FROM Users WHERE Login = ?username AND Password = ?userpass",
                        new List<MySqlParameter>()
                        {
                            new MySqlParameter("username", LoginTB.Text),
                            new MySqlParameter("userpass", PasswordMTB.Text)
                        }
                    )[0]
                ) > 0
            )
*/
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
