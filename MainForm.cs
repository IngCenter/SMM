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

            //Список всех статей (и не надо тут долбаные 9 столбцов)
            List<string> results = Program.Select("SELECT ID, Title FROM Articles");            

            int y = 50;
            
            //Там 9 столбцов
            for (int i = 0; i < results.Count; i = i + 2)
            {
                //Для каждой создаем лейбл
                Label lbl = new Label();
                lbl.AutoSize = true;
                //Чтобы оно открылось в новом окне, сохраняем текст и описание
                lbl.Text = results[i + 1];
                lbl.AccessibleDescription = results[i];
                lbl.Click += new EventHandler(openArticle);
                lbl.Location = new Point(30, y);
                lbl.Size = new Size(500, 30);
                //И добавляем на панель со статьями
                ArticlesPanel.Controls.Add(lbl);
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

        /// <summary>
        /// Добавить статью
        /// </summary>
        private void button1_Click(object sender, EventArgs e)
        {
            AddArticle addArticle = new AddArticle();
            addArticle.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //А давай человек Марсель сделает ввод логина и пароля. А, человек Марсель?
            SignInForm SignIn = new SignInForm();
            SignIn.ShowDialog();
            if (Program.CurrentUser.Trim() != "")
            {
                SignInButton.Visible = false;
                UserInfoButton.Visible = true;
            } else
            {
                SignInButton.Visible = true;
                UserInfoButton.Visible = false;
            };
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Program.CurrentUser.Trim() != "")
                SignInLabel.Text = "Привет, " + Program.CurrentUser.Trim();
           
            else
                SignInLabel.Text = "Вы ещё не вошли в аккаунт?";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://is.gd/QRJ0bT");
        }

        private void SignInLabel_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            //И вот сюда личный кабинет вместо войти
            UserForm UserInfo = new UserForm();
            UserInfo.ShowDialog();
        }

        private void ArticlesPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
