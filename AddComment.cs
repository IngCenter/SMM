using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class AddComment : Form
    {
        int articleId = 0;
        public AddComment(int _articleId = 0)
        {
            InitializeComponent();
            articleId = _articleId;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Program.CurrentUser.Trim() == "")
                return;

            Program.Insert(
                "INSERT INTO Comments (Author, ArticleId, Text) VALUES ('" +
                Program.CurrentUser + "', " + articleId + ", '" + textBox1.Text + "')");

            /* TODO:
             * СРОЧНО изменить этот временный способ на максимально безопасный -
             * параметаризованный запрос!!!!!!
             */
        }
    }
}
