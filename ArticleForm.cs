using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp2
{   
    public partial class ArticleForm : Form
    {
        string id = "0";
        public ArticleForm(string Id)
        {
            InitializeComponent();

            id = Id;
            List<string> info = Program.Select("SELECT Title, Text, Topic, Tags, Author FROM Articles WHERE ID = " + id);
            nameLabel.Text = info[0];
            textLabel.Text = info[1];

            /*Вариант ниже читаемее. Нет?
             * if (Convert.ToBoolean(
                Program.Select("SELECT * FROM Articles WHERE Title = '" + name + "' ORDER BY id DESC LIMIT 1")[8]
                )
            )*/
            //MarkDown. Даша, Марсель, тут страшно
            if (Program.Select("SELECT UseMarkDown FROM Articles WHERE ID = " + id)[0] == "1")
            {
                // используем MarkDown
                ConvertMdArticleToHtml(info[1]);
                WebBrowser mdWb = new WebBrowser();
                mdWb.Location = new System.Drawing.Point(9, 60);
                mdWb.Size = new System.Drawing.Size(714, 309);
                mdWb.DocumentText = System.IO.File.ReadAllText("cache.html");
                // TODO: Доделать, т.к. сейчас скрипт MarkDown'а не работает!

                textLabel.Visible = false;
                Controls.Add(mdWb);
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
                Program.Insert(
                    "INSERT INTO Likes(`Like`, `DisLike`, User, Article) VALUES('0', '0', '" + Program.CurrentUser + "', '" + id + "');");
                // TODO: Картинку дизлайка тоже надо поменять
            }
            // Я поставил лайк
            else
            {
                LikePB.Image = Properties.Resources.LikeOn;
                LikePB.Tag = "not";
                Program.Insert(
                    "INSERT INTO Likes(`Like`, `DisLike`, User, Article) VALUES('1', '0', '" + Program.CurrentUser + "', '" + id + "');");
            }
        }
        
        private void CommPB_Click(object sender, EventArgs e)
        {
            Comments Comm = new Comments();
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
                Program.Insert(
                    "INSERT INTO Likes(`Like`, `Dislike`, User, Article) VALUES('0', '0', '" + Program.CurrentUser + "', '" + id + "');");
            }
            //Поставил дизлайк
            else
            {
                DislikePB.Image = Properties.Resources.DisLikeOn;
                DislikePB.Tag = "not";
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
            sw.WriteLine("<div class='main-content'>");
            sw.WriteLine(article_text);
            sw.WriteLine("</div>");
            sw.WriteLine("<script src='showdown/dist/showdown.min.js'></script>");
            sw.WriteLine("<script>");
            sw.WriteLine("var mdtext = document.getElementByClassName('main-content')[0];");
            sw.WriteLine("mdtext.innerHTML = new showdown.Converter().makeHtml(mdtext.innerHTML);");
            sw.WriteLine("</script>");
            sw.WriteLine("</body>");
            sw.WriteLine("</html>");
            sw.Close();
        }
    }
}
