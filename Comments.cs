using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp2
{
    public partial class Comments : Form
    {
        public Comments()
        {
            InitializeComponent();

            //А если тут будет учитываться номер статьи?
            List<string> results = Program.Select("SELECT * FROM Comments");

            int y = 50;
            

            for (int i = 0; i < results.Count; i = i + 4)
            {
                //Для каждой создаем лейбл
                
                CommLable.Text += results[i + 1] + Environment.NewLine + 
                results[i + 3] + Environment.NewLine + y;
                //Чтобы оно открылось в новом окне, сохраняем текст и описание
            }


        }

        private void Comments_Load(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
