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
            
            nameLabel.Text = name;
            textLabel.Text = text;

            //КОличество лайков/дизлайков
            List<string> likes = Program.Select(
                "SELECT SUM(Likes.Like) FROM Likes WHERE Article = 1");
            label1.Text = likes[0];

            List<string> Dislikes = Program.Select(
               "SELECT SUM(Likes.Dislike) FROM Likes WHERE Article = 1");
            label2.Text = Dislikes[0];
            
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
         " DELETE FROM Likes WHERE User = 'Misha' AND Article = 1" );

            if (LikePB.Tag.ToString() == "not")
            {
                LikePB.Image = Properties.Resources.LikeOff;
                LikePB.Tag = "like";
                Program.Insert(

         " INSERT INTO Likes(`Like`, User, Article) VALUES('0', '0', 'Misha', '1');");
            }
            else
            {
                LikePB.Image = Properties.Resources.LikeOn;
                LikePB.Tag = "not";
                Program.Insert(
                    " INSERT INTO Likes(`Like`, User, Article) VALUES('0', '1', 'Misha', '1');");
               

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
            Program.Insert(
        " DELETE FROM Disikes WHERE User = 'Misha' AND Article = 1");

            if (DislikePB.Tag.ToString() == "not")
            {
                DislikePB.Image = Properties.Resources.DislikeOff;
                DislikePB.Tag = "Dislike";
                Program.Insert(

         " INSERT INTO Dislikes(`Dislike`, User, Article) VALUES('0', '0', 'Misha', '1');");
            }
            else
            {
                DislikePB.Image = Properties.Resources.DislikeOn;
                DislikePB.Tag = "not";
                Program.Insert(
                    " INSERT INTO Dislikes(`Dislike`, User, Article) VALUES('0', '1', 'Misha', '1');");


            }
        }
    }
}
