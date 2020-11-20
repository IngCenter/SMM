using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            UserForm UserInfo = new UserForm();
            UserInfo.ShowDialog();
            Close();
        }

        private void SignInLLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistrationForm Registration = new RegistrationForm();
            Registration.Show();
        }

        private void SignInLabel_Click(object sender, EventArgs e)
        {

        }

        private void SignInForm_Load(object sender, EventArgs e)
        {

        }

        private void LoginLabel_Click(object sender, EventArgs e)
        {

        }

        private void LoginTB_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
