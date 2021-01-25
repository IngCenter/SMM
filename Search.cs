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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
            GetArticlesByFilter();

            // Заполнение ComboBox'ов "теги", "тема" и "автор"
            List<string> tags = Program.Select("SELECT Tags FROM Articles");
            foreach (string tag in tags.ToArray())
            {
                string[] parts = tag.Split(new string[] { ", " }, StringSplitOptions.None);
                foreach (string part in parts)
                {
                    if (!tags.Contains(part) && part.Trim() != "")
                        tags.Add(part);
                }
            }
            tags.Sort();
            //TagFilterBox.Items.Clear();
            //TagFilterBox.Items.Add("");
            //TagFilterBox.Items.AddRange(tags.ToArray());

            TopicFilterBox.Items.Clear();
            TopicFilterBox.Items.Add("");
            Program.Select("SELECT DISTINCT Topic FROM Articles ORDER BY Topic").ForEach((string topic) =>
            {
                if (topic.Trim() != "")
                    TopicFilterBox.Items.Add(topic);
            });

        }

        private void FilterTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void findButton_Click(object sender, EventArgs e)
        {
            GetArticlesByFilter(TagFilterBox.Text, TopicFilterBox.Text, AuthorFilterBox.Text);
        }
    }
}
