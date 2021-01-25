using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp2
{
    public partial class UserForm : UserControl
    {
        int userId = 0;
        public UserForm()
        {
            InitializeComponent();

            // Отключение рекламы в профилях администратора и одного из разработчиков -- DarkCat09
            if (Program.CurrentUser == "ADMIN007" || Program.CurrentUser == "DarkCat09")
            {
                checkBox1.Enabled = true;
                checkBox1.Visible = true;
            }
            checkBox1.Checked = MainForm.disableAd;

            // Заполнение формы данными о пользователе
            UserNameLabel.Text = Program.CurrentUser;
            List<string> result = Program.Select(
                "SELECT Id, Subscribers FROM Users WHERE Login = ?username ORDER BY Id DESC LIMIT 1",
                new List<MySqlParameter>()
                {
                    new MySqlParameter("username", Program.CurrentUser)
                }
            );
            if (result.Count > 0)
            {
                userId = Convert.ToInt32(result[0]);
                UserIDLabel.Text = "#" + userId;

                short userSubsLastDigit = Convert.ToInt16(Convert.ToInt32(result[1]) % 10);
                UserSubsLabel.Text =
                    result[1] + " " + (
                    (userSubsLastDigit == 1) ? "подписчик" :
                    (userSubsLastDigit >= 2 && userSubsLastDigit <= 4) ? "подписчика" :
                    "подписчиков"
                );

                AvatarPB.Image = Program.SelectImage(
                    "SELECT IFNULL(Avatar, '') AS Avatar FROM Users WHERE Id = " + userId +
                    " ORDER BY Id DESC LIMIT 1"
                );
            }
        }

        private void UserArticleLabel_Click(object sender, EventArgs e)
        {
            UserArticles ArticlesInfo = new UserArticles();
            ArticlesInfo.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.CurrentUser = "";
           // Close();
        }

        private void UserFeedBackLabel_Click(object sender, EventArgs e)
        {
            Comments commentsInfo = new Comments(-1, Program.CurrentUser);
            commentsInfo.Show();
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            UserNameLabel.Text = Program.CurrentUser.Trim();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            MainForm.disableAd = checkBox1.Checked;
        }

        private void AvatarPB_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() != DialogResult.Cancel)
                if (
                    MessageBox.Show(
                        "Вы точно хотите изменить аватарку профиля?", "Подтверждение",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Information
                    ) == DialogResult.Yes
                )
                {
                    Program.InsertImage(
                        "UPDATE Users SET Avatar = ?binfile WHERE Id = " + userId,
                        openFileDialog1.FileName
                    );
                }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Subscribes SubInfo = new Subscribes();
            SubInfo.Show();
        }
    }
}
