using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class AdminUsersForm : Form
    {
        public AdminUsersForm()
        {
            InitializeComponent();
        }

        private void AdminUsersForm_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            List<string> users = Program.Select("SELECT Login, FIO, Year FROM Users");
            for (int i = 0; i < users.Count; i = i + 3)
            {
                string[] row = new string[3];
                row[0] = users[i];
                row[1] = users[i + 1];
                row[2] = users[i + 2];
                dataGridView1.Rows.Add(row);

                if (Convert.ToInt32(users[i+2]) < 2000)
                    dataGridView1.Rows[i/3].DefaultCellStyle.BackColor = Color.Red;
            }
        }
    }
}
