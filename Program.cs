using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp2
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


            string connString =
                "Server = VH287.spaceweb.ru; Database = beavisabra_gazet;" +
                "port = 3306; User Id = beavisabra_gazet; password = Beavis1989";
            conn = new MySqlConnection(connString);
            conn.Open();

            Application.Run(new MainForm());
            
            conn.Close();
        }

        /// <summary>
        /// Соединение
        /// </summary>
        public static MySqlConnection conn;

        public static List<string> Select(string Text)
        {
            //Результат
            List<string> results = new List<string>();
            //Создать команду
            MySqlCommand command = new MySqlCommand(Text, conn);

            //Выполнить команду
            DbDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                for (int i = 0; i < reader.FieldCount; i++)
                    results.Add(reader.GetValue(i).ToString());
            }
            reader.Close();

            return results;
        }
    }
}
