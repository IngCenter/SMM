using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class ArticlesFromCherdakly : Form
    {
        public ArticlesFromCherdakly()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region 20 последних новостей
            HtmlWeb webGet = new HtmlWeb();
            webGet.AutoDetectEncoding = false;
            webGet.OverrideEncoding = Encoding.GetEncoding("utf-8");
            HtmlAgilityPack.HtmlDocument document = webGet.Load("http://chdshi.uln.muzkult.ru/news/");
           
            var Nodes = document.DocumentNode.SelectNodes("//div[contains(@class, 'news_list_item')]");

            foreach (var Node in Nodes)
            {
                string s = Node.InnerHtml;
                s = s.Replace("    <a class=\"link\" href=", "");
                string[] parts = s.Split(new char[] { '"' });

                string newsLink = parts[1];
                string newsName = parts[2].Replace("><strong>", "").Replace("</strong><div class=", "");

                string exist = Program.Select("SELECT COUNT(*) FROM Articles WHERE Title = '" + newsName + "'")[0];
                if (exist == "0")
                    Program.Insert(
                        "INSERT INTO Articles(Title, Author, Topic, Link)" +
                        " VALUES('" + newsName + "', 'Mikhail', 'Новости Чердаклов', '" + newsLink + "')");
            }
            #endregion

            #region Обновляем тексты новостей
            List<string> news =
                Program.Select("SELECT Id, Link FROM Articles WHERE Link != '' ");

            for (int i = 0; i < news.Count; i = i + 2)
            {
                webGet = new HtmlWeb();
                webGet.AutoDetectEncoding = false;
                webGet.OverrideEncoding = Encoding.GetEncoding("utf-8");
                document = webGet.Load("http://chdshi.uln.muzkult.ru" + news[i + 1]);

                Nodes = document.DocumentNode.SelectNodes("//div[contains(@class, 'full_news_article')]");
                string description = Nodes[0].InnerText.Replace("&nbsp;", " ");
                description = description.Replace("<p>", "");
                description = description.Replace("</p>", "\n");
                description = description.Replace("<br/>", "\n");

                var pars = new List<MySql.Data.MySqlClient.MySqlParameter>() 
                    { new MySql.Data.MySqlClient.MySqlParameter("descript", description) };
                Program.Insert(
                    "UPDATE Articles SET Text = ?descript" +
                    " WHERE Id = " + news[i], pars);
            }
            #endregion
        }
    }
}
