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
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void UserArticleLabel_Click(object sender, EventArgs e)
        {
            UserArticles ArticlesInfo = new UserArticles();
            ArticlesInfo.Show();
        }

        private void UserNameLabel_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.CurrentUser = "";
            Close();
        }

        private void UserFeedBackLabel_Click(object sender, EventArgs e)
        {
            Comments commentsInfo = new Comments();
            commentsInfo.Show();
        }

        private void UserNameLabel_Click_1(object sender, EventArgs e)
        {
           
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            UserNameLabel.Text = Program.CurrentUser.Trim();
        }
    }
}
