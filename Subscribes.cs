using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp2
{
    public partial class Subscribes : UserControl
    {
        public Subscribes()
        {
            InitializeComponent();
        }

        private void MySubscribers(string _sub = "")
        {
            /*  string command = "SELECT Name FROM Users WHERE 1 ";
              if (_sub.Trim() != "")
              {
                  _sub = "%" + Program.CurrentUser + "%";
                  command += "AND Users LIKE ?users ";
              }*/

              

            // SELECT COUNT(*) FROM Subscribers WHERE IdAuthor = (SELECT Id FROM Users WHERE Login = '" + Program.Login + "')

            
          /*  if (_sub.Trim() != "")
            {
                _sub = "%" + Program.CurrentUser + "%";
                command += "AND Users LIKE ?users ";
            }*/

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string command = "SELECT FIO FROM Subscribers JOIN Users ON Users.Id = Subscribers.IdUser WHERE IdAuthor = (SELECT Id FROM Users WHERE Login = '" + Program.CurrentUser + "')";
            List<string> results = Program.Select(command);

            label1.Text = "";

            for (int i = 0; i < results.Count; i = i + 1)
            {
                label1.Text += results[i] + Environment.NewLine ;
            }
        }

        private void Subscribes_Load(object sender, EventArgs e)
        {

        }
    }
}
