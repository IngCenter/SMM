using System;
using System.Collections.Generic;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp2
{
    public partial class AddArticle : Form
    {
        public AddArticle()
        {
            InitializeComponent();
            toolTip1.SetToolTip(TagsTB, "Теги пишутся через запятую с пробелом, без решётки");
        }
        public AddArticle(string _title, string _tags, string _topic, string _text, bool _usemd)
        {
            InitializeComponent();
            toolTip1.SetToolTip(TagsTB, "Теги пишутся через запятую с пробелом, без решётки");

            NameTB.Text         = _title;
            TagsTB.Text         = _tags;
            TopicTB.Text        = _topic;
            ArticleTextTB.Text  = _text;
            checkBox1.Checked   = _usemd;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.Insert(
                "INSERT INTO `Articles` (Title, Author, Tags, Topic, DT, UseMarkdown) " +
                "VALUES (?heading, ?username, ?tags, ?topic, sysdate(), " + checkBox1.Checked + ")",
                new List<MySqlParameter>()
                {
                    new MySqlParameter("heading", NameTB.Text),
                    new MySqlParameter("username", Program.CurrentUser),
                    new MySqlParameter("tags", TagsTB.Text),
                    new MySqlParameter("topic", TopicTB.Text)
                }
            );
            MessageBox.Show("Сохранено!");
        }
    }
}
