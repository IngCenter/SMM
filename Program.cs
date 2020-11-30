using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Drawing;
using System.IO;
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

        public static void Insert(string Text, List<MySqlParameter> sqlParams = null)
        {
            // Создать команду
            MySqlCommand command = new MySqlCommand(Text, conn);

            // Добавить параметры, если есть
            if (sqlParams != null)
                sqlParams.ForEach((MySqlParameter _sqlparam) => {
                    command.Parameters.Add(_sqlparam);
                });

            // Выполнить команду
            command.ExecuteNonQuery();
        }

        /// <summary>
        /// Соединение
        /// </summary>
        public static MySqlConnection conn;

        /// <summary>
        /// Текущий пользователь
        /// </summary>
        public static string CurrentUser = "";


        public static Image SelectImage(String Text)
        {
            Image img = null;
            MySqlCommand command = new MySqlCommand(Text, conn);
            MySqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                // Предполагается, что в запросе 1 столбец, и в нем картинка
                byte[] data = (byte[])reader.GetValue(0);
                try
                {
                    MemoryStream ms = new MemoryStream(data, 0, data.Length);
                    ms.Write(data, 0, data.Length);
                    img = Image.FromStream(ms, true); // Конвертируем в картинку
                }
                catch { }
            }

            reader.Close();
            return img;
        }

        public static List<string> Select(string Text, List<MySqlParameter> sqlParams = null)
        {
            //Результат
            List<string> results = new List<string>();
            //Создать команду
            MySqlCommand command = new MySqlCommand(Text, conn);

            // Добавить параметры, если есть
            if (sqlParams != null)
                sqlParams.ForEach((MySqlParameter _sqlparam) => {
                    command.Parameters.Add(_sqlparam);
                });

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
