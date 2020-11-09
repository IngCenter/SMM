using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class UserArticles : Form
    {
        public UserArticles()
        {
            InitializeComponent();

            //Список всех статей (и не надо тут долбаные 9 столбцов)
            List<string> results = Program.Select("SELECT ID, Title FROM Articles WHERE Author = '" + Program.CurrentUser + "'");

            int y = 50;
            //Там 7 столбцов
            for (int i = 0; i < results.Count; i = i + 2)
            {
                //Для каждой создаем лейбл
                Label lbl = new Label();
                lbl.AutoSize = true;
                //Чтобы оно открылось в новом окне, сохраняем Id
                lbl.Text = results[i + 1];
                lbl.AccessibleDescription = results[i];
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
            ArticleForm af = new ArticleForm(lbl.AccessibleDescription);
            af.Show();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddArticle addArticle = new AddArticle();
            addArticle.Show();
        }
    }
}
