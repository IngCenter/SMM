using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            Application.Run(new MainForm());
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

            conn.Close();

            return results;
        }
    }
}
