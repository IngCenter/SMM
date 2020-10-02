using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using System.Data.Common;
using MySql.Data.MySqlClient;


namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();

            //Подключение к БД
            string connString =
                "Server = VH287.spaceweb.ru; Database = beavisabra_gazet;" +
                "port = 3306; User Id = beavisabra_gazet; password = Beavis1989";
            MySqlConnection conn = new MySqlConnection(connString);
            conn.Open();

            //Создать команду
            MySqlCommand command = new MySqlCommand("SELECT * FROM Articles", conn);
            //Выполнить команду
            DbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                //Сохранить результат
                string s = reader.GetString(0);
            }
            reader.Close();

            conn.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }
    }
}
