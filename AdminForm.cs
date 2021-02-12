using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace WindowsFormsApp2
{
    public partial class AdminForm : UserControl
    {
        string pythonPath =
            System.IO.Directory.GetDirectoryRoot(Environment.SystemDirectory) + "Users\\" +
            Environment.UserName + "\\AppData\\Local\\Programs\\Python38\\pythonw.exe";
        
        public Color color;
        public AdminForm()

        {
            public static void ApplyDesign(Control form)
            {
                form.BackColor = color;
                form.Font = font;
                form.ForeColor = foreColor;
            }

            {
            InitializeComponent();
        }

        


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
                string[] userDataArr = new string[7]
                {
                    "Удалить", usersData[i+0], usersData[i+1], usersData[i+2],
                    usersData[i+3], usersData[i+4], usersData[i+5]
                };

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
            /*
             * TODO:
             * Запуск скрипта парсинга в отдельном потоке.
             * 
             * System.Threading.Thread.Start(функция);                      - запуск
             * dataGridView4.Invoke(() => { добавляем данные в dgv4; });    - заполнение таблицы из другого потока
             * 
             * Кстати, во втором куске кода есть лямбда-выражение, моё любимое :)
             * (c) 2020 DarkCat09
             * 
             */
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
                color = Color.WhiteSmoke;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            color = Color.Gray;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            color = Color.Silver;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            color = Color.RosyBrown;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            color = Color.Salmon;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            color = Color.Bisque;
        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            color = Color.Orange;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            color = Color.Khaki;
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            color = Color.DarkSeaGreen;
        }

        private void radioButton10_CheckedChanged(object sender, EventArgs e)
        {
            color = Color.LightGreen;
        }

        private void radioButton11_CheckedChanged(object sender, EventArgs e)
        {
            color = Color.SkyBlue;
        }

        private void radioButton12_CheckedChanged(object sender, EventArgs e)
        {
            color = Color.MediumPurple;
        }

        private void radioButton13_CheckedChanged(object sender, EventArgs e)
        {
            color = Color.Plum;
        }

        private void radioButton14_CheckedChanged(object sender, EventArgs e)
        {
            color = Color.Pink;
        }
    }
}
