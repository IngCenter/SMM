using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class PictureForm : Form
    {
        public PictureForm(string Id)
        {
            InitializeComponent();
            pictureBox1.Image = Program.SelectImage("SELECT IFNULL(Picture, '') As Picture FROM Articles WHERE Id = " + Id);
        }
    }
}
