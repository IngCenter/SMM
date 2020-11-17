using System;
using System.Windows.Forms;

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
                "INSERT INTO `Articles` (Title, Author, Tags, Topic, DT, UseMarkdown) VALUES ('" +
                NameTB.Text + "', '" + Program.CurrentUser + "', '" + TagsTB.Text + "', '" + TopicTB.Text +
                "', sysdate(), " + checkBox1.Checked + ")"
            );
            MessageBox.Show("Сохранено!");
        }
    }
}
