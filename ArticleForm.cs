using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp2
{   
    public partial class ArticleForm : Form
    {
        public ArticleForm(string name, string text)
        {
            InitializeComponent();
            
            // Сохраняй каталоги Pictures и Properties. Или терпи мои картинки :)

            nameLabel.Text = name;
            textLabel.Text = text;

            // Количество лайков/дизлайков
            List<string> likes = Program.Select(
                "SELECT SUM(Likes.Like) FROM Likes WHERE Article = 1");
            // TODO: А как насчет вместо 1 чтобы была цифра соответственно названию статьи?
            label1.Text = likes[0];

            List<string> Dislikes = Program.Select(
               "SELECT SUM(Likes.Dislike) FROM Likes WHERE Article = 1");
            label2.Text = Dislikes[0];

            // Ставил ли лайк лично я?
            string MyLike = Program.Select(
                "SELECT SUM(Likes.Like) FROM Likes WHERE Article = 1 AND User = '" + Program.CurrentUser + "'")[0];
            if (MyLike != "0")
            {
                LikePB.Image = Properties.Resources.LikeOn;
                LikePB.Tag = "not";
            }

            // Ставил ли дизлайк лично я?
            string MyDislike = Program.Select(
                "SELECT SUM(Likes.Like) FROM Likes WHERE Article = 1 AND User = '" + Program.CurrentUser + "'")[0];
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
                "DELETE FROM Likes WHERE User = '" + Program.CurrentUser + "' AND Article = 1" );

            // Я убрал лайк
            if (LikePB.Tag.ToString() == "not")
            {
                LikePB.Image = Properties.Resources.LikeOff;
                LikePB.Tag = "like";
                Program.Insert(
                    "INSERT INTO Likes(`Like`, `DisLike`, User, Article) VALUES('0', '0', '" + Program.CurrentUser + "', '1');");
                // TODO: Картинку дизлайка тоже надо поменять
            }
            // Я поставил лайк
            else
            {
                LikePB.Image = Properties.Resources.LikeOn;
                LikePB.Tag = "not";
                Program.Insert(
                    "INSERT INTO Likes(`Like`, `DisLike`, User, Article) VALUES('1', '0', '" + Program.CurrentUser + "', '1');");   
            }
        }
        
        private void CommPB_Click(object sender, EventArgs e)
        {
            Comments Comm = new Comments();
            Comm.Show();
        }

        private void DislikePB_Click(object sender, EventArgs e)
        {
            Program.Insert("DELETE FROM Likes WHERE User = '" + Program.CurrentUser + "' AND Article = 1");

            //Убрал дизлайк
            if (DislikePB.Tag.ToString() == "not")
            {
                DislikePB.Image = Properties.Resources.DisLikeOff;
                DislikePB.Tag = "Dislike";
                Program.Insert(
                    "INSERT INTO Likes(`Like`, `Dislike`, User, Article) VALUES('0', '0', '" + Program.CurrentUser + "', '1');");
            }
            //Поставил дизлайк
            else
            {
                DislikePB.Image = Properties.Resources.DisLikeOn;
                DislikePB.Tag = "not";
                Program.Insert(
                    "INSERT INTO Likes(`Like`, `Dislike`, User, Article) VALUES('0', '1', '" + Program.CurrentUser + "', '1');");
            }
        }
    }
}
