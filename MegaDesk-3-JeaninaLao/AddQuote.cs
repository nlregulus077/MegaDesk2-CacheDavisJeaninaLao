using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MegaDesk_3_JeaninaLao
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();

            List<Desk.SurfaceMaterial> materials = Enum.GetValues(typeof(Desk.SurfaceMaterial)).Cast<Desk.SurfaceMaterial>().ToList();
            materialBox.DataSource = materials;
           
        }

        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
            Close();
        }

        private void AddQuote_FormClosed(object sender, FormClosedEventArgs e) {

            var mainMenu = (MainMenu)Tag;
            mainMenu.Show();
        }

        private void btnGetQuote_Click(object sender, EventArgs e)
        {
            DeskQuote deskOrder = new DeskQuote();
            deskOrder.calcQuote();
        }
    }
}
