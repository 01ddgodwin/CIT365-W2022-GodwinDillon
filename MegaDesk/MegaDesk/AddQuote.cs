using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk
{
    public partial class AddQuote : Form
    {
        public AddQuote()
        {
            InitializeComponent();
        }

        private void backToMainMenu_Click(object sender, EventArgs e)
        {
            MainMenu viewMainMenu = (MainMenu)Tag;
            viewMainMenu.Show();
            Close();
        }

        private void AddQuote_Load(object sender, EventArgs e)
        {

        }

        private void fullNameTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void drawersDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Calculate_Click(object sender, EventArgs e)
        {
           
        }

        private void width_Click(object sender, EventArgs e)
        {

        }

        private void widthTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void depth_Click(object sender, EventArgs e)
        {

        }

        private void depthTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void numbOfDrawers_Click(object sender, EventArgs e)
        {

        }

        private void materialDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void rushOptionDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void material_Click(object sender, EventArgs e)
        {

        }

        private void rushOptions_Click(object sender, EventArgs e)
        {

        }
    }
}
