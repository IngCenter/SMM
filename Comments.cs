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
            string sqlCommand = "";
            List<string> results = null;

            sqlCommand =
            (
                (articleId == -1) ?
                "SELECT * FROM Comments WHERE 1" :
                "SELECT * FROM Comments WHERE ArticleId = " + articleId.ToString()
            );
            
            if (_author.Trim() != "")
            {
                comboBox1.Text = _author;
                sqlCommand += " AND Author = ?author";
                results = Program.Select(sqlCommand, new List<MySqlParameter>() {
                    new MySqlParameter("author", _author)
                });
            }
            else
            {
                results = Program.Select(sqlCommand);
            }
            
            for (int i = 0; i < results.Count; i = i + 5)
            {
                CommLable.Text += results[i + 1] + Environment.NewLine + results[i + 3];
                // TODO: Чтобы оно открылось в новом окне, сохраняем текст и описание
            }

            Program.Select("SELECT Login FROM Users").ForEach((string userlogin) => {
                comboBox1.Items.Add(userlogin);
            });
            Program.Select("SELECT Title FROM Articles").ForEach((string arttitle) => {
                comboBox2.Items.Add(arttitle);
            });

            // TODO: Комментарии по статье! Марсель, я ж на тебя надеялся! (c) 2020 DarkCat09
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
    }
}
