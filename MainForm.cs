using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    /// <summary>
    /// Структура "статья" (скоро будет не нужна)
    /// </summary>
    public struct Article
    {
        public string name;
        public string text;

        public Article(string _name, string _text)
        {
            name = _name;
            text = _text;
        }
    }

    public partial class MainForm : Form
    {
        /// <summary>
        /// Скоро избавимся от него
        /// </summary>
        List<Article> articles_list = new List<Article>();

        public MainForm()
        {
            InitializeComponent();


            
            
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

        private void button2_Click(object sender, EventArgs e)
        {
            SignInForm SignIn = new SignInForm();
            SignIn.ShowDialog();            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Program.CurrentUser.Trim() != "")
                SignInLabel.Text = "Привет, " + Program.CurrentUser.Trim();
            else
                SignInLabel.Text = "Вы ещё не вошли в аккаунт";

            // Вход отображаем, если логин не задан
            SignInButton.Visible = (Program.CurrentUser.Trim() == "");
            UserInfoButton.Visible = (Program.CurrentUser.Trim() != "");

            // Отображение кнопки администрирования,
            // если пользователь администратор - ADMIN007
            AdminButton.Visible = (Program.CurrentUser == "ADMIN007");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(
                "Открыть страницу renderforest.com в браузере?", "Вопрос",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information
                ).ToString() == "Yes")
            {
                System.Diagnostics.Process.Start("https://is.gd/QRJ0bT");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //И вот сюда личный кабинет вместо войти
            UserForm UserInfo = new UserForm();
            UserInfo.ShowDialog();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            AdminForm AdminInfo = new AdminForm();
            AdminInfo.ShowDialog();
        }

        private void ArticlesPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string command = "SELECT ID, Title  FROM Articles WHERE 1";
            if (FilterTB.Text != "")
                command += " AND Tags LIKE '%" + FilterTB.Text + "%'";
            int y = 50;
            List<string> results = Program.Select(command);
            // Получаем 3 столбца
            // Список всех статей (и не надо тут долбаные 9 столбцов)

            for (int i = 0; i < results.Count; i = i + 2)
            {
                // Для каждого комментария создаем лейбл:
                Label lbl = new Label();
                lbl.AutoSize = true;
                // Чтобы оно открылось в новом окне, сохраняем текст и описание:
                lbl.Text = results[i + 1];
                lbl.AccessibleDescription = results[i];
                lbl.Click += new EventHandler(openArticle);
                lbl.Location = new Point(30, y);
                lbl.Size = new Size(500, 30);
                // И добавляем на панель со статьями:
                ArticlesPanel.Controls.Add(lbl);
                y += 50;
            }
        }
    }
}
