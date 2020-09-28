using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class ArticleForm : Form
    {
        public ArticleForm(string name, string text)
        {
            InitializeComponent();
            nameLabel.Text = name;
            textLabel.Text = text;
        }

        private void Article_Load(object sender, EventArgs e)
        {

        }

        private void LikePB_Click(object sender, EventArgs e)
        {

            if (LikePB.Tag.ToString() == "not")
            {
                LikePB.Image = Properties.Resources.LikeOff;
                LikePB.Tag = "like";
            }
            else
            {
                LikePB.Image = Properties.Resources.LikeOn;
                LikePB.Tag = "not";
            }
        }
    }
}
