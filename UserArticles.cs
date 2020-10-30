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
    public partial class UserArticles : Form
    {
        public UserArticles()
        {
            InitializeComponent();

            //Program.CurrentUser

            //Список всех статей
            List<string> results = Program.Select("SELECT * FROM Articles WHERE Author = 'DarkCat09'");

            int y = 50;
            //Там 7 столбцов
            for (int i = 0; i < results.Count; i = i + 8)
            {
                //Для каждой создаем лейбл
                Label lbl = new Label();
                lbl.AutoSize = true;
                //Чтобы оно открылось в новом окне, сохраняем текст и описание
                lbl.Text = results[i + 1];
                lbl.AccessibleDescription = results[i + 5];
                lbl.Click += new EventHandler(openArticle);
                lbl.Location = new Point(30, y);
                lbl.Size = new Size(500, 30);
                //И добавляем на панель со статьями
                UserArticlesPanel.Controls.Add(lbl);
                y += 50;
            }
        }

        /// <summary>
        /// Открываем статью в новом окне
        /// </summary>
      public static void openArticle(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            ArticleForm af = new ArticleForm(lbl.Text, lbl.AccessibleDescription);
            af.Show();
        }
    
        private void UserArticlesPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserArticles_Load(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddArticle addArticle = new AddArticle();
            addArticle.Show();
        }
    }
}
