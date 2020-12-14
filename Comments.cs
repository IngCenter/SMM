using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp2
{
    public partial class Comments : Form
    {
        int articleId = -1;
        public Comments(int _articleId = -1, string _author = "")
        {
            InitializeComponent();
            articleId = _articleId;
            ShowFilteredComments(articleId, _author);

            Program.Select("SELECT DISTINCT Author FROM Comments").ForEach((string userlogin) => {
                comboBox1.Items.Add(userlogin);
            });
            Program.Select("SELECT Title FROM Articles").ForEach((string arttitle) => {
                comboBox2.Items.Add(arttitle);
            });
        }

        private void ShowFilteredComments(int artid, string author)
        {
            string sqlCommand = "";
            List<string> results = null;

            sqlCommand =
            (
                (artid == -1) ?
                "SELECT * FROM Comments WHERE 1" :
                "SELECT * FROM Comments WHERE ArticleId = " + artid
            );

            if (author.Trim() != "")
            {
                comboBox1.Text = author;
                sqlCommand += " AND Author = ?author";
                results = Program.Select(sqlCommand, new List<MySqlParameter>() {
                    new MySqlParameter("author", author)
                });
            }
            else
            {
                results = Program.Select(sqlCommand);
            }

            for (int i = 0; i < results.Count; i = i + 5)
            {
                CommLable.Text += results[i + 1] + Environment.NewLine + results[i + 3];
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (articleId == -1)
            {
                if (MessageBox.Show(
                    "При создании объекта Comments не был получен идентификатор статьи,\n" +
                    "поэтому комментарий будет добавлен к первой статье (id=1).\n" + "Продолжить?",
                    "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning
                    ).ToString() == "No"
                )
                {
                    return;
                }
                articleId = 1;
            }
            AddComment acForm = new AddComment(articleId);
            acForm.ShowDialog();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowFilteredComments(articleId, comboBox1.Text);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            articleId = Convert.ToInt32(
                Program.Select("SELECT Id FROM Articles WHERE Title LIKE ?title LIMIT 1", new List<MySqlParameter>()
                {
                    new MySqlParameter("title", comboBox2.Text)
                })[0]
            ); // А если будут две статьи с одинаковым заголовком? Всё плохо... (c) 2020 DarkCat09
            ShowFilteredComments(articleId, comboBox1.Text);
        }
    }
}
