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
            Desk desk = new Desk();
            DeskQuote deskOrder = new DeskQuote();

            deskOrder.CustomerName = textBox1.Text;

            desk.Width = (int)numericWidthBox.Value;
            desk.Depth = (int)numericDepthBox.Value;
            desk.NumberOfDrawers = (int)drawerNumberBox.Value;
            string material = materialBox.SelectedItem.ToString();

            if (material == "Laminate")
            {
                desk.DeskMaterial = Desk.SurfaceMaterial.Laminate;
            }

            else if (material == "Oak")
            {
                desk.DeskMaterial = Desk.SurfaceMaterial.Oak;
            }

            else if (material == "Rosewood")
            {
                desk.DeskMaterial = Desk.SurfaceMaterial.Rosewood;
            }

            else if (material == "Veneer")
            {
                desk.DeskMaterial = Desk.SurfaceMaterial.Veneer;
            }

            else if (material == "Pine")
            {
                desk.DeskMaterial = Desk.SurfaceMaterial.Pine;
            }

            deskOrder.Desk = desk;

            try
            {
                deskOrder.RushOption = rushBox.SelectedItem.ToString();

            } catch (NullReferenceException)
            {
                deskOrder.RushOption = "Standard (14 Days)";
            }
          

            deskOrder.FinalQuote = deskOrder.CalcQuote(deskOrder.RushOption);

            label3.Text = "$" + deskOrder.FinalQuote;

            // deskOrder.WriteQuote(customer, rush, totalQuote);

           // deskOrder.WriteQuote(deskOrder);
        }
    }
}
