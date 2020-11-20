using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp2
{   
    public partial class ArticleForm : Form
    {
        string id = "0";
        
        public ArticleForm(string Id, bool administrating = false)
        {
            id = Id;
            InitializeComponent();

            if (Program.CurrentUser == "ADMIN007")
            {
                SaveButton.Visible = true;
                textLabel.Enabled = true;
                textLabel.ReadOnly = false;
            }
            else 
            { 
                textLabel.ReadOnly = true;
                SaveButton.Visible = false;
            }
            List<string> info = Program.Select("SELECT Title, Text, Topic, Tags, Author FROM Articles WHERE ID = " + id);
            nameLabel.Text = info[0];
            textLabel.Text = info[1];

            //MarkDown. Даша, Марсель, тут страшно
            bool usemd = Convert.ToBoolean(Program.Select("SELECT UseMarkDown FROM Articles WHERE ID = " + id)[0]);
            if (usemd && !administrating)
            {
                // используем MarkDown
                ConvertMdArticleToHtml(info[1]);
                WebBrowser mdWb = new WebBrowser();
                mdWb.Location = new System.Drawing.Point(9, 60);
                mdWb.Size = new System.Drawing.Size(714, 309);
                mdWb.DocumentText = System.IO.File.ReadAllText("cache.html");

                if (
                    MessageBox.Show(
                        "Скорее всего, MarkDown-статья не сможет правильно обработаться встроенным в C# браузером.\n" +
                        "Открыть статью в Вашем браузере?", "Вопрос",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information
                    ).ToString() == "No"
                )
                {
                    textLabel.Visible = false;
                    Controls.Add(mdWb);
                }
                else
                {
                    System.Diagnostics.Process.Start(
                        "\"file:///" + System.IO.Directory.GetCurrentDirectory() +
                        "\\cache.html\"");
                }
            }


            // Количество лайков/дизлайков
            List<string> likes = Program.Select(
                "SELECT IFNULL(SUM(Likes.Like), 0) FROM Likes WHERE Article = " + id);
            // TODO: А как насчет вместо 1 чтобы была цифра соответственно названию статьи?
            label1.Text = likes[0];

            List<string> Dislikes = Program.Select(
               "SELECT IFNULL(SUM(Likes.Dislike), 0) FROM Likes WHERE Article = " + id);
            label2.Text = Dislikes[0];

            // Ставил ли лайк лично я?
            string MyLike = Program.Select(
                "SELECT IFNULL(SUM(Likes.Like), 0) FROM Likes WHERE Article = " + id + 
                " AND User = '" + Program.CurrentUser + "'")[0];
            if (MyLike != "0")
            {
                LikePB.Image = Properties.Resources.LikeOn;
                LikePB.Tag = "not";
            }

            // Ставил ли дизлайк лично я?
            string MyDislike = Program.Select(
                "SELECT IFNULL(SUM(Likes.Dislike), 0) FROM Likes WHERE Article = " + id + 
                " AND User = '" + Program.CurrentUser + "'")[0];
            if (MyDislike != "0")
            {
                DislikePB.Image = Properties.Resources.DisLikeOn;
                DislikePB.Tag = "not";
            }
        }

        /// <summary>
        /// Меняем картинку по клику на лайк
        /// </summary>
        private void LikePB_Click(object sender, EventArgs e)
        {
            Program.Insert(
                "DELETE FROM Likes WHERE User = '" + Program.CurrentUser + "' AND Article = " + id);

            // Я убрал лайк
            if (LikePB.Tag.ToString() == "not")
            {
                LikePB.Image = Properties.Resources.LikeOff;
                LikePB.Tag = "like";
                label1.Text = (Convert.ToInt32(label1.Text) - 1).ToString();
                Program.Insert(
                    "INSERT INTO Likes(`Like`, `DisLike`, User, Article) VALUES('0', '0', '" + Program.CurrentUser + "', '" + id + "');");
                // TODO: Картинку дизлайка тоже надо поменять
            }
            // Я поставил лайк
            else
            {
                LikePB.Image = Properties.Resources.LikeOn;
                LikePB.Tag = "not";
                label1.Text = (Convert.ToInt32(label1.Text) + 1).ToString();
                Program.Insert(
                    "INSERT INTO Likes(`Like`, `DisLike`, User, Article) VALUES('1', '0', '" + Program.CurrentUser + "', '" + id + "');");
            }
        }
        
        private void CommPB_Click(object sender, EventArgs e)
        {
            Comments Comm = new Comments(Convert.ToInt32(id));
            Comm.Show();
        }

        private void DislikePB_Click(object sender, EventArgs e)
        {
            Program.Insert("DELETE FROM Likes WHERE User = '" + Program.CurrentUser + "' AND Article = " + id);

            //Убрал дизлайк
            if (DislikePB.Tag.ToString() == "not")
            {
                DislikePB.Image = Properties.Resources.DisLikeOff;
                DislikePB.Tag = "Dislike";
                label2.Text = (Convert.ToInt32(label1.Text) + 1).ToString();
                Program.Insert(
                    "INSERT INTO Likes(`Like`, `Dislike`, User, Article) VALUES('0', '0', '" + Program.CurrentUser + "', '" + id + "');");
            }
            //Поставил дизлайк
            else
            {
                DislikePB.Image = Properties.Resources.DisLikeOn;
                DislikePB.Tag = "not";
                label2.Text = (Convert.ToInt32(label1.Text) + 1).ToString();
                Program.Insert(
                    "INSERT INTO Likes(`Like`, `Dislike`, User, Article) VALUES('0', '1', '" + Program.CurrentUser + "', '" + id + "');");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ConvertMdArticleToHtml(string article_text)
        {
            System.IO.StreamWriter sw = new System.IO.StreamWriter("cache.html", false, System.Text.Encoding.UTF8);
            sw.WriteLine("<!DOCTYPE html>");
            sw.WriteLine("<html>");
            sw.WriteLine("<head>");
            sw.WriteLine("<meta charset='UTF-8' />");
            sw.WriteLine("</head>");
            sw.WriteLine("<body>");
            sw.WriteLine("<div id='main-content'></div>");
            sw.WriteLine(
                "<script src='file:///" + System.IO.Directory.GetCurrentDirectory() +
                "/showdown/dist/showdown.min.js'></script>"
            );
            sw.WriteLine("<script>");
            sw.WriteLine("var article_text = `");
            sw.WriteLine(article_text.Replace("`", "\\`"));
            sw.WriteLine("`");
            sw.WriteLine("var mdtext = document.getElementById('main-content');");
            sw.WriteLine("mdtext.innerHTML = new showdown.Converter().makeHtml(article_text);");
            sw.WriteLine("</script>");
            sw.WriteLine("</body>");
            sw.WriteLine("</html>");
            sw.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Program.Insert("UPDATE Articles" +
                " SET name = '" + textLabel.Text + "'" +
                " WHERE Id = '" + id + "'");
            MessageBox.Show("Обновлено");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            new PictureForm(id).ShowDialog();
        }
    }
}