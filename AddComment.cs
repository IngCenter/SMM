using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp2
{
    public partial class AddComment : Form
    {
        int articleId = 1;
        public AddComment(int _articleId = 1)
        {
            InitializeComponent();
            articleId = _articleId;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Program.CurrentUser.Trim() == "")
                return;

            Program.Insert(
                "INSERT INTO Comments (Author, ArticleId, Text) VALUES (?username, artid, commtext)",
                new List<MySqlParameter>()
                {
                    new MySqlParameter("username", Program.CurrentUser),
                    new MySqlParameter("artid", articleId),
                    new MySqlParameter("commtext", textBox1.Text)
                }
            );
        }
    }
}
