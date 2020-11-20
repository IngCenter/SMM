using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Comments : Form
    {
        int articleId = -1;
        public Comments(int _articleId = -1)
        {
            InitializeComponent();

            articleId = _articleId;
            List<string> results;
            if (articleId != -1)
            {
                results = Program.Select("SELECT * FROM Comments");
            }
            else
            {
                results = Program.Select(
                    "SELECT * FROM Comments WHERE ArticleId = " + articleId.ToString());
            }

            //int y = 50;
            
            for (int i = 0; i < results.Count; i = i + 4)
            {
                CommLable.Text += results[i + 1] + Environment.NewLine + results[i + 3];
                // TODO: Чтобы оно открылось в новом окне, сохраняем текст и описание
            }

            Program.Select("SELECT Login FROM Users").ForEach((string userlogin) => {
                comboBox1.Items.Add(userlogin);
            });
            Program.Select("SELECT Title FROM Articles").ForEach((string arttitle) => {
                comboBox2.Items.Add(arttitle);
            });

            // TODO: Комментарии по статье! Марсель, я ж на тебя надеялся! (c) 2020 DarkCat09
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (articleId == -1)
            {
                if (MessageBox.Show(
                    "При создании объекта Comments не был получен идентификатор статьи,\n" +
                    "поэтому комментарий будет добавлен к первой статье (id=0).\n" + "Продолжить?",
                    "Предупреждение", MessageBoxButtons.YesNo, MessageBoxIcon.Warning
                    ).ToString() == "No"
                )
                {
                    return;
                }
            }
            AddComment acForm = new AddComment();
            acForm.ShowDialog();
        }

        private void CommLable_TextChanged(object sender, EventArgs e)
        {

        }

        private void Comments_Load(object sender, EventArgs e)
        {

        }
    }
}
