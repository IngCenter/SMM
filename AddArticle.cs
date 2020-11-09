using System;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class AddArticle : Form
    {
        public AddArticle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //А если кроме названия здесь будут текст и теги? Человек Марсель?
            Program.Insert("INSERT INTO `Articles` (Title, DT) VALUES ('" + NameTB.Text + "', sysdate())");
            MessageBox.Show("Сохранено");
        }
    }
}
