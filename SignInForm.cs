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
            /* Пользователь не должен знать, ЧТО именно он ввёл неверно.
             * Так хакер запросто может перебрать логины и узнать,
             * какие есть зарегистрированные пользователи.
             * 
             * Поэтому не надо менять следующий код!
             * 
             * Если уж так хочется заменить на предыдущее,
             * оставьте мой настроенный MessageBox!
             * 
             * (Это было для Даши и Марселя).
             * 
             * (c) 2020 DarkCat09
             */
            if (
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
            {
                Program.CurrentUser = LoginTB.Text;
                Close();
            }
            else
            {
                MessageBox.Show(
                    "Неверное имя пользователя или пароль!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error
                );
            }
        } 

        private void SignInLLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationForm Registration = new RegistrationForm();
            Registration.Show();
        }
    }
}
