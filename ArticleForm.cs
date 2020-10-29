using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.Common;



namespace WindowsFormsApp2
{   
    public partial class ArticleForm : Form
    {
        public ArticleForm(string name, string text)
        {
            InitializeComponent();
            
            //Сохраняй папки Pictures и Properties. Или терпи мои картинки:)

            nameLabel.Text = name;
            textLabel.Text = text;

            //КОличество лайков/дизлайков
            List<string> likes = Program.Select(
                "SELECT SUM(Likes.Like) FROM Likes WHERE Article = 1");
            //А как насчет вместо 1 чтобы была цифра соответственно названию статьи?
            label1.Text = likes[0];

            List<string> Dislikes = Program.Select(
               "SELECT SUM(Likes.Dislike) FROM Likes WHERE Article = 1");
            label2.Text = Dislikes[0];

            //СТавил ли лайки лично я?
            string MyLike = Program.Select(
                "SELECT SUM(Likes.Like) FROM Likes WHERE Article = 1 AND User = '" + Program.CurrentUser + "'")[0];
            if (MyLike != "0")
            {
                LikePB.Image = Properties.Resources.LikeOn;
                LikePB.Tag = "not";
            }

            //Ставил ли дизлайк лично я?
        }

        private void Article_Load(object sender, EventArgs e)
        {
        }

        /// <summary>
        /// Меняем картинку по клику на лайк
        /// </summary>
        private void LikePB_Click(object sender, EventArgs e)
        {
            Program.Insert(
                "DELETE FROM Likes WHERE User = '" + Program.CurrentUser + "' AND Article = 1" );

            //Я убрал лайк
            if (LikePB.Tag.ToString() == "not")
            {
                LikePB.Image = Properties.Resources.LikeOff;
                LikePB.Tag = "like";
                Program.Insert(
                    "INSERT INTO Likes(`Like`, `DisLike`, User, Article) VALUES('0', '0', '" + Program.CurrentUser + "', '1');");
                //Картинку дизлайка тоже надо поменять
            }
            //Я поставил лайк
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DislikePB_Click(object sender, EventArgs e)
        {
            //Program.CurrentUser
            Program.Insert("DELETE FROM Likes WHERE User = 'Misha' AND Article = 1");

            //Убрал дизлайк
            if (DislikePB.Tag.ToString() == "not")
            {
                DislikePB.Image = Properties.Resources.DisLikeOff;
                DislikePB.Tag = "Dislike";
                Program.Insert(
                    " INSERT INTO Likes(`Like`, `Dislike`, User, Article) VALUES('0', '0', 'Misha', '1');");
            }
            //Поставил дизлайк
            else
            {
                DislikePB.Image = Properties.Resources.DisLikeOn;
                DislikePB.Tag = "not";
                Program.Insert(
                    " INSERT INTO Likes(`Like`, `Dislike`, User, Article) VALUES('0', '1', 'Misha', '1');");
            }
        }
    }
}
