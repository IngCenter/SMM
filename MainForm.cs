using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp2
{
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
        List<Article> articles_list = new List<Article>();

        public MainForm()
        {
            InitializeComponent();

            /*
             Подключение к БД
            Залезть в таблицу
            Что-то из нее прочитать (куда-то сохранить)
            Вывести на экран
             */
            //Подключение к БД
            string connString =
                "Server = VH287.spaceweb.ru; Database = beavisabra_gazet;" +
                "port = 3306; User Id = beavisabra_gazet; password = Beavis1989";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();

            List<string> results = new List<string>(); 

            //Создать команду
            MySqlCommand command = new MySqlCommand("SELECT * FROM Articles", conn);
            //Выполнить команду
            DbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                //Сохранить результат
                string title = reader.GetValue(0).ToString();
                string author = reader.GetValue(1).ToString();
                string text = reader.GetValue(4).ToString();

                articles_list.Add(new Article(title, text));

                results.Add(text);
            }
            reader.Close();

            

            conn.Close();

            //string[] lines = System.IO.file.ReadAllLines("Статьи.txt");

            /*articles_list.Add(new Article("Интересно",
                "Кто убил Япончика...\n" +
                "Что если это...\n" +
                "Он сам"));
            articles_list.Add(new Article("Ой-ой-ой",
                "Что же происходит..."));
            */
            int y = 10;
            foreach (Article art in articles_list)
            {
                Label lbl = new Label();
                lbl.AutoSize = true;
                lbl.Text = art.name;
                lbl.Click += new EventHandler(openArticle);
                lbl.AccessibleDescription = art.text;
                lbl.Location = new Point(10, y);
                lbl.Size = new Size(500, 30);
                Controls.Add(lbl);
                y += lbl.Size.Height;
            }
        }

        public static void openArticle(object sender, EventArgs e)
        {
            Label lbl = (Label)sender;
            ArticleForm af = new ArticleForm(lbl.Text, lbl.AccessibleDescription);
            af.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
