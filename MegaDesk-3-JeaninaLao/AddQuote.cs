using System;
using System.Windows.Forms;

namespace MegaDesk_3_JeaninaLao
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
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

        private void widthInput_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void widthInput_Validated(object sender, EventArgs e)
        {

        }

        private void widthInput_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
