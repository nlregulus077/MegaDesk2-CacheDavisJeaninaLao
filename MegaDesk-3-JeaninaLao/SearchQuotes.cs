using System;
using System.IO;
using System.Windows.Forms;

namespace MegaDesk_3_JeaninaLao
{
    public partial class SearchQuotes : Form
    {
        public SearchQuotes()
        {
            InitializeComponent();
            ShowQuotes();
        }

        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void SearchQuotes_FormClosed(object sender, FormClosedEventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
        }

        public void ShowQuotes()
        {
            using (StreamReader quoteFile = new StreamReader("quotes.json"))
            {
                string[] quoteLines = File.ReadAllLines(@"quotes.json");

                foreach (string quoteline in quoteLines)
                {
                    string[] element = quoteline.Split(new char[] { ',' });
                    gridQuotes.Rows.Add(element);
                }

            }
        }

        public void ShowQuotes2(string search)
        {
            using (StreamReader quoteFile = new StreamReader("quotes.json"))
            {
                string[] quoteLines = File.ReadAllLines(@"quotes.json");

                gridQuotes.Rows.Clear();
                    foreach (string quoteline in quoteLines)
                    {
                        if (quoteline.Contains(search))
                        {
                            string[] element = quoteline.Split(new char[] { ',' });
                            gridQuotes.Rows.Add(element);
                        }
                        
                    }

              
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string searchTerm = searchBox.SelectedItem.ToString();
            ShowQuotes2(searchTerm);
        }
    }
}
