using System;
using System.IO;
using System.Diagnostics;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp2
{
    public partial class AdminForm : Form
    {
        string pythonPath =
            System.IO.Directory.GetDirectoryRoot(Environment.SystemDirectory) + "Users\\" +
            Environment.UserName + "\\AppData\\Local\\Programs\\Python38\\pythonw.exe";

        public AdminForm()
        {
            InitializeComponent();
            openFileDialog1.InitialDirectory = new System.IO.FileInfo(pythonPath).DirectoryName;
            openFileDialog1.Filter = "Исполняемые файлы (*.exe)|*.exe|Все файлы (*.*)|*.*";
            openFileDialog1.RestoreDirectory = true;

            textBox1.Text = pythonPath;

            #region Добавление данных в DGV1 (управление статьями)

            dataGridView1.Rows.Clear();

            List<string> articlesData =
                Program.Select("SELECT Id, Title, Author, Tags, Topic, DT, UseMarkdown FROM Articles");

            for (int i = 0; i < articlesData.Count; i += 7)
            {
                string[] articleDataArr = new string[10]
                {
                    "Открыть", "Удалить", articlesData[i+0], articlesData[i+1],
                    articlesData[i+4], articlesData[i+3], articlesData[i+2],
                    articlesData[i+5], articlesData[i+6], "Выбрать"
                };

                dataGridView1.Rows.Add(articleDataArr);
            }

            #endregion

            #region Добавление данных в DGV2 (управление комментариями)

            dataGridView2.Rows.Clear();

            List<string> commentsData =
                Program.Select("SELECT Id, Author, ArticleId, Text, IFNULL(DT, '17-11-2020') As DT FROM Comments");

            for (int i = 0; i < commentsData.Count; i += 5)
            {
                string[] commentDataArr = new string[6]
                {
                    "Удалить", commentsData[i+0], commentsData[i+2], commentsData[i+1],
                    commentsData[i+3], commentsData[i+4]
                };

                dataGridView2.Rows.Add(commentDataArr);
            }

            #endregion

            #region Добавление данных в DGV3 (управление пользователями)

            dataGridView3.Rows.Clear();

            List<string> usersData =
                Program.Select("SELECT Id, Login, Password, FIO, Year, Subscribers FROM Users");

            for (int i = 0; i < usersData.Count; i += 6)
            {
                List<string> userAdData =
                    Program.Select(
                        "SELECT Articles.Topic, SUM(Likes.Like-Likes.Dislike) FROM `Articles` " +
                        "JOIN Likes ON Articles.Id = Likes.Article " +
                        "WHERE Likes.User LIKE ?username " +
                        "GROUP BY Articles.Topic " +
                        "HAVING SUM(Likes.Like - Likes.Dislike) > 0 " +
                        "LIMIT 1",
                        new List<MySqlParameter>()
                        {
                            new MySqlParameter("username", usersData[i+1])
                        }
                    );

                string[] userDataArr = null;
                if (userAdData.Count > 0)
                {
                    userDataArr = new string[8]
                    {
                    "Удалить", usersData[i+0], usersData[i+1], usersData[i+2],
                    usersData[i+3], usersData[i+4], usersData[i+5], userAdData[0]
                    };
                }
                else
                {
                    userDataArr = new string[7]
                    {
                        "Удалить", usersData[i+0], usersData[i+1], usersData[i+2],
                        usersData[i+3], usersData[i+4], usersData[i+5]
                    };
                }

                dataGridView3.Rows.Add(userDataArr);
            }

            #endregion

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int selectedArticleId = Convert.ToInt32(((DataGridView)sender).Rows[e.RowIndex].Cells[2].Value);

                if (e.ColumnIndex == 0)
                    new ArticleForm(selectedArticleId.ToString(), true).Show();

                if (e.ColumnIndex == 1)
                {
                    string deleteRequest = "DELETE FROM Articles WHERE Id = " + selectedArticleId;
                    if (
                        MessageBox.Show(
                            "Вы уверены, что хотите выполнить этот запрос?\n" + deleteRequest,
                            "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning
                        ).ToString() == "Yes"
                    )
                    {
                        Program.Insert(deleteRequest);
                    }
                }
            }
            catch (Exception)
            {
                // ничего не делаем
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int selectedCommentId = Convert.ToInt32(((DataGridView)sender).Rows[e.RowIndex].Cells[1].Value);

                if (e.ColumnIndex == 0)
                {
                    string deleteRequest = "DELETE FROM Comments WHERE Id = " + selectedCommentId;
                    if (
                        MessageBox.Show(
                            "Вы уверены, что хотите выполнить этот запрос?\n" + deleteRequest,
                            "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning
                        ).ToString() == "Yes"
                    )
                    {
                        Program.Insert(deleteRequest);
                    }
                }
            }
            catch (Exception)
            {
                // ничего не делаем
            }
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int selectedUserId = Convert.ToInt32(((DataGridView)sender).Rows[e.RowIndex].Cells[1].Value);

                if (e.ColumnIndex == 0)
                {
                    string deleteRequest = "DELETE FROM Comments WHERE Id = " + selectedUserId;
                    if (
                        MessageBox.Show(
                            "Вы уверены, что хотите выполнить этот запрос?\n" + deleteRequest,
                            "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning
                        ).ToString() == "Yes"
                    )
                    {
                        Program.Insert(deleteRequest);
                    }
                }
            }
            catch (Exception)
            {
                // ничего не делаем
            }
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // TODO: просмотр текста статьи с Хабра (клик на изменить)
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog().ToString() != "Cancel")
            {
                pythonPath = openFileDialog1.FileName;
                textBox1.Text = pythonPath;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            pythonPath = textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new System.Threading.Thread(GetHabrNews).Start();
        }

        private void GetHabrNews()
        {
            try
            {
                // Извлекаем скрипт
                if (File.Exists("habr_parsing.py"))
                    File.Delete("habr_parsing.py");
                FileStream script_file = File.Open("habr_parsing.py", FileMode.CreateNew);
                BinaryWriter sbw = new BinaryWriter(script_file);
                sbw.Write(Properties.Resources.habr_parsing);
                sbw.Close();
                script_file.Close();

                // Запускаем интерпретатор с нашим скриптом
                ProcessStartInfo pyprocinfo = new ProcessStartInfo()
                {
                    FileName = "\"" + pythonPath + "\"",
                    Arguments = "\"" + Directory.GetCurrentDirectory() + "\\habr_parsing.py\"",
                    WindowStyle = ProcessWindowStyle.Hidden,
                    UseShellExecute = false,
                    RedirectStandardOutput = true
                };
                Process pyproc = Process.Start(pyprocinfo);

                // Парсим вывод парсера :)
                StreamReader pyprocsr = pyproc.StandardOutput;
                string line;
                short parsing_mode = 0; // 0 = старт, 1 = запись статьи и заголовка, 2 = запись текста
                while ((line = pyprocsr.ReadLine()) != null)
                {
                    if (line.StartsWith("----- "))
                    {
                        /* Первая проверка для того, чтобы зря не расходовать
                         * ресурсы на сравнение огромных строк
                         */
                        if (line.Equals("----- beginning of article") && parsing_mode == 0)
                            parsing_mode = 1;
                        if (line.Equals("----- beginning of text") && parsing_mode == 1)
                            parsing_mode = 2;
                        if (line.Equals("----- end of text") && parsing_mode == 2)
                            parsing_mode = 1;
                        if (line.Equals("----- end of article") && parsing_mode == 1)
                            parsing_mode = 0;
                        // Потом в тернарный оператор переделаю (c) 2020 DarkCat09
                    }
                    // TODO: Доделать!!!
                }
            } catch (Exception)
            {
                // пока что ничего не делаем
            }
        }
    }
}
