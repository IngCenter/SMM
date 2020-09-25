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

            articles_list.Add(new Article("Интересно",
                "Кто убил Япончика...\n" +
                "Что если это...\n" +
                "Он сам"));
            articles_list.Add(new Article("Ой-ой-ой",
                "Что же происходит..."));

            int y = 10;
            foreach (Article art in articles_list)
            {
                Label lbl = new Label();
                lbl.Text = art.name;
                lbl.Click += new EventHandler(openArticle);
                lbl.AccessibleDescription = art.text;
                lbl.Location = new Point(10, y);
                Controls.Add(lbl);
                y += 20;
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
