using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
            List<DeskQuote> deskQuotes = new List<DeskQuote>();
            using (StreamReader quoteFile = new StreamReader(@"quotes.json"))
            {

                string quotes = quoteFile.ReadToEnd();
                deskQuotes = JsonConvert.DeserializeObject<List<DeskQuote>>(quotes);

                gridQuotes.DataSource = deskQuotes.Select(d => new
                {
                    Name = d.CustomerName,
                    Width = d.Desk.Width,
                    Depth = d.Desk.Depth,
                    Drawers = d.Desk.NumberOfDrawers,
                    Material = d.Desk.DeskMaterial,
                    DeliveryOption = d.RushOption,
                    Quote = d.FinalQuote,
                    Date = d.QuoteDate
                }).ToList();

            }
        }

        public void SearchForQuotes(string search)
        {
            List<DeskQuote> deskQuotes = new List<DeskQuote>();
            using (StreamReader quoteFile = new StreamReader(@"quotes.json"))
            {

                string quotes = quoteFile.ReadToEnd();
                deskQuotes = JsonConvert.DeserializeObject<List<DeskQuote>>(quotes);

                gridQuotes.DataSource = deskQuotes.Select(d => new
                {
                    Name = d.CustomerName,
                    Width = d.Desk.Width,
                    Depth = d.Desk.Depth,
                    Drawers = d.Desk.NumberOfDrawers,
                    Material = d.Desk.DeskMaterial,
                    DeliveryOption = d.RushOption,
                    Quote = d.FinalQuote,
                    Date = d.QuoteDate
                }).Where(q =>  q.Material.ToString() == search)
                .ToList();

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string searchTerm = searchBox.SelectedItem.ToString();
            SearchForQuotes(searchTerm);
        }
    }
}
