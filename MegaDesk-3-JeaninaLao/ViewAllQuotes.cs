using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace MegaDesk_3_JeaninaLao
{
    public partial class ViewAllQuotes : Form
    {
        public ViewAllQuotes()
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

        private void ViewAllQuotes_FormClosed(object sender, FormClosedEventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
        }

        public void ShowQuotes()
        {
            using (StreamReader quoteFile = new StreamReader("quotes.txt"))
            {
                string[] quoteLines = File.ReadAllLines(@"quotes.txt");
                
                foreach (string quoteline in quoteLines)
                {
                    string[] element = quoteline.Split(new char[] { ',' });
                    gridQuotes.Rows.Add(element);
                }
                
            }
        }
    }
}
