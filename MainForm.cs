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

        public static Panel mainPanel;
        public MainForm()
        {
            InitializeComponent();
            mainPanel = ArticlesPanel;
            AdminForm.color = Properties.Settings.Default.Color;
            AdminForm.fontColor = Properties.Settings.Default.FontColor;
            AdminForm.font = Properties.Settings.Default.Font;
            
            Search search = new Search();
            search.Dock = DockStyle.Fill;
            ArticlesPanel.Controls.Clear();
            ArticlesPanel.Controls.Add(search);
                                               
            // Всё, нужное для MarkDown'а:
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

        private void button2_Click(object sender, EventArgs e)
        {
            SignInForm SignIn = new SignInForm();

            ArticlesPanel.Controls.Clear();
            ArticlesPanel.Controls.Add(SignIn);
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

            AdminForm.ApplyDesign(this);
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
            // И вот сюда личный кабинет вместо войти
            UserForm UserInfo = new UserForm();
            UserInfo.Dock = DockStyle.Fill;
           
            ArticlesPanel.Controls.Clear();
            ArticlesPanel.Controls.Add(UserInfo);
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            AdminForm AdminInfo = new AdminForm();
            AdminInfo.Dock = DockStyle.Fill;

            ArticlesPanel.Controls.Clear();
            ArticlesPanel.Controls.Add(AdminInfo);
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

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            Search comments = new Search();
            comments.Dock = DockStyle.Fill;
            ArticlesPanel.Controls.Clear();
            ArticlesPanel.Controls.Add(comments);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Comments comments = new Comments();
            comments.Dock = DockStyle.Fill;
            ArticlesPanel.Controls.Clear();
            ArticlesPanel.Controls.Add(comments);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            UserForm comments = new UserForm();
            comments.Dock = DockStyle.Fill;
            ArticlesPanel.Controls.Clear();
            ArticlesPanel.Controls.Add(comments);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            AddArticle comments = new AddArticle();
            comments.Dock = DockStyle.Fill;
            ArticlesPanel.Controls.Clear();
            ArticlesPanel.Controls.Add(comments);
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Color = AdminForm.color;
            Properties.Settings.Default.Font = AdminForm.font;
            Properties.Settings.Default.FontColor = AdminForm.fontColor;
            Properties.Settings.Default.Save();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Subscribes comments = new Subscribes();
            comments.Dock = DockStyle.Fill;
            ArticlesPanel.Controls.Clear();
            ArticlesPanel.Controls.Add(comments);
        }
    }
} 
