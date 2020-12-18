using System;
using System.IO;
using System.Drawing;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

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
        public static bool disableAd = false;
        public MainForm()
        {
            InitializeComponent();
            GetArticlesByFilter();

            // Заполнение ComboBox'ов "теги", "тема" и "автор"
            List<string> tags = Program.Select("SELECT Tags FROM Articles");
            List<string> tags1 = new List<string>();
            foreach (string tag in tags.ToArray())
            {
                string[] parts = tag.Split(new string[] { ", " }, StringSplitOptions.None);
                foreach (string part in parts)
                {
                    if (!tags1.Contains(part) && part.Trim() != "")
                        tags1.Add(part);
                }
            }
            tags1.Sort();
            TagFilterBox.Items.Clear();
            TagFilterBox.Items.Add("");
            TagFilterBox.Items.AddRange(tags1.ToArray());

            TopicFilterBox.Items.Clear();
            TopicFilterBox.Items.Add("");
            Program.Select("SELECT DISTINCT Topic FROM Articles ORDER BY Topic").ForEach((string topic) =>
            {
                if (topic.Trim() != "")
                    TopicFilterBox.Items.Add(topic);
            });

            AuthorFilterBox.Items.Clear();
            AuthorFilterBox.Items.Add("");
            Program.Select("SELECT DISTINCT Login FROM Users ORDER BY Login").ForEach((string author_name) =>
            {
                if (author_name.Trim() != "")
                    AuthorFilterBox.Items.Add(author_name);
            }); // DISTINCT - на всякий пожарный случай

            // Всё, нужное для MarkDown'а:
            /*
            try
            {
                if (File.Exists("7za.exe"))
                    File.Delete("7za.exe");
                FileStream sevenz_file = File.Open("7za.exe", FileMode.CreateNew);
                BinaryWriter szbw = new BinaryWriter(sevenz_file);
                szbw.Write(Properties.Resources._7za);
                szbw.Close();
                sevenz_file.Close();

                if (File.Exists("showdown.zip"))
                    File.Delete("showdown.zip");
                FileStream showdown_file = File.Open("showdown.zip", FileMode.CreateNew);
                BinaryWriter sdbw = new BinaryWriter(showdown_file);
                sdbw.Write(Properties.Resources.showdown);
                sdbw.Close();
                showdown_file.Close();

                if (Directory.Exists("showdown"))
                    Directory.Delete("showdown", true);
                string curdir = Directory.GetCurrentDirectory();

                System.Diagnostics.ProcessStartInfo sevenz_psi = new System.Diagnostics.ProcessStartInfo()
                {
                    FileName = "cmd.exe",
                    Arguments = "/c \"\"" + curdir + "\\7za.exe\" x \"" + curdir + "\\showdown.zip\"\"",
                    WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden,
                    CreateNoWindow = true
                };
                System.Diagnostics.Process.Start(sevenz_psi);

                MessageBox.Show("Файлы для MarkDown готовы!", "Отладка"); //for debug
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Произошла ошибка при разархивации нужных для обработки MarkDown'а файлов!\n" +
                    ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error
                );
            }
            */
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

            // Отключаем рекламу в текущей "сессии", если того хочет Админ или DarkCat09 (Disabling Advert)
            if (disableAd)
                Controls.Remove(AdvertistingPanel);
        }

        /// <summary>
        /// Открываем статью в новом окне
        /// </summary>
        public static void OpenArticle(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            ArticleForm af = new ArticleForm(lbl.AccessibleDescription);
            af.Show();
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            SignInForm SignIn = new SignInForm();
            SignIn.ShowDialog();
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

        private void UserInfoButton_Click(object sender, EventArgs e)
        {
            // И вот сюда личный кабинет вместо войти
            UserForm UserInfo = new UserForm();
            UserInfo.ShowDialog();
        }

        private void AdminButton_Click(object sender, EventArgs e)
        {
            AdminForm AdminInfo = new AdminForm();
            AdminInfo.Show();
        }

        private void GetArticlesByFilter(string _tag = "", string _topic = "", string _author = "")
        {
            string command = "SELECT ID, Title FROM Articles WHERE 1 ";
            if (_tag.Trim() != "") {
                _tag = "%" + Tag + "%";
                command += "AND Tags LIKE ?tags ";
            }
            if (_topic.Trim() != "")
                command += "AND Topic = ?topic ";
            if (_author.Trim() != "")
                command += "AND Author = ?author ";
            command += "ORDER BY ID DESC "; // пробел в конце - на всякий случай
                                            // (хотя, обычно после DESC не ставят JOIN'ы...)

            // Очищаем старые статьи
            panel1.Controls.Clear();

            int y = 20;
            List<string> results = Program.Select(command, new List<MySqlParameter>() {
                new MySqlParameter("tags", _tag),
                new MySqlParameter("topic", _topic),
                new MySqlParameter("author", _author)
            });
            
            // Добавляем новые статьи
            for (int i = 0; i < results.Count; i += 2)
            {
                // Для каждого комментария создаем лейбл:
                Label lbl = new Label();
                lbl.AutoSize = true;
                // Чтобы оно открылось в новом окне, сохраняем текст и описание:
                lbl.Text = results[i + 1];
                lbl.AccessibleDescription = results[i];
                lbl.Click += new EventHandler(OpenArticle);
                lbl.Location = new Point(4, y);
                lbl.Size = new Size(500, 30);
                // И добавляем на панель со статьями:
                panel1.Controls.Add(lbl);
                y += 50;
            }
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            GetArticlesByFilter(TagFilterBox.Text, TopicFilterBox.Text, AuthorFilterBox.Text);
        }
    }
}