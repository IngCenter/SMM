using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;


namespace WindowsFormsApp2
{
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
            GetArticlesByFilter();

            // Заполнение ComboBox'ов "теги", "тема" и "автор"
            List<string> tags = Program.Select("SELECT Tags FROM Articles");
            foreach (string tag in tags.ToArray())
            {
                string[] parts = tag.Split(new string[] { ", " }, StringSplitOptions.None);
                foreach (string part in parts)
                {
                    if (!tags.Contains(part) && part.Trim() != "")
                        tags.Add(part);
                }
            }
            tags.Sort();
            //TagFilterBox.Items.Clear();
            //TagFilterBox.Items.Add("");
            //TagFilterBox.Items.AddRange(tags.ToArray());

            TopicFilterBox.Items.Clear();
            TopicFilterBox.Items.Add("");
            Program.Select("SELECT DISTINCT Topic FROM Articles ORDER BY Topic").ForEach((string topic) =>
            {
                if (topic.Trim() != "")
                    TopicFilterBox.Items.Add(topic);
            });

        }

        private void FilterTB_TextChanged(object sender, EventArgs e)
        {

        }
        private void GetArticlesByFilter(string _tag = "", string _topic = "", string _author = "")
        {
            string command = "SELECT ID, Title FROM Articles WHERE 1 ";
            if (_tag.Trim() != "")
            {
                _tag = "%" + Tag + "%";
                command += "AND Tags LIKE ?tags ";
            }
            if (_topic.Trim() != "")
                command += "AND Topic = ?topic ";
            if (_author.Trim() != "")
                command += "AND Author = ?author ";
            command += "ORDER BY ID DESC "; // пробел в конце - на всякий случай
                                            // (хотя, обычно после DESC не ставят JOIN'ы...)

            // Очищаем старые статьи
            panel1.Controls.Clear();

            int y = 20;
            List<string> results = Program.Select(command, new List<MySqlParameter>() {
                new MySqlParameter("tags", _tag),
                new MySqlParameter("topic", _topic),
                new MySqlParameter("author", _author)
            });

            // Добавляем новые статьи
            for (int i = 0; i < results.Count; i += 2)
            {
                // Для каждого комментария создаем лейбл:
                Label lbl = new Label();
                lbl.AutoSize = true;
                // Чтобы оно открылось в новом окне, сохраняем текст и описание:
                lbl.Text = results[i + 1];
                lbl.AccessibleDescription = results[i];
                lbl.Click += new EventHandler(OpenArticle);
                lbl.Location = new Point(4, y);
                lbl.Size = new Size(500, 30);
                // И добавляем на панель со статьями:
                panel1.Controls.Add(lbl);
                y += 50;
            }
        }

        /// <summary>
        /// Открываем статью в новом окне
        /// </summary>
        public static void OpenArticle(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            ArticleForm af = new ArticleForm(lbl.AccessibleDescription);
            af.Show();
        }


        private void findButton_Click(object sender, EventArgs e)
        {
            GetArticlesByFilter(TagFilterBox.Text, TopicFilterBox.Text, AuthorFilterBox.Text);
        }
    }
}
