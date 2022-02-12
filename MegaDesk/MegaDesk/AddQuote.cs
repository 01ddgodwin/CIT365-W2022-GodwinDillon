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
        DeskQuote newDeskQuote = new DeskQuote();
        Desk newDesk = new Desk();
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

        public void fullNameTextbox_TextChanged(object sender, EventArgs e)
        {
            DeskQuote newDeskQuote = new DeskQuote();
            DeskQuote.FullName = fullNameTextbox.Text;
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
            DisplayQuote viewDisplayQuote = new DisplayQuote();
            viewDisplayQuote.Tag = this;
            viewDisplayQuote.Show(this);
            this.Hide();

            DeskQuote newDeskQuote = new DeskQuote();
            DisplayQuote newDisplayQuote = new DisplayQuote();
            Desk newDesk = new Desk();

            DeskQuote.FullName = fullNameTextbox.Text;
            newDesk.Width = int.Parse(widthTextbox.Text);
            newDesk.Depth = int.Parse(depthTextbox.Text);

            materialDropdown.DataSource = Enum.GetValues(typeof(Desk.material));
            

            Console.WriteLine(newDesk.Width);

            DeskQuote.SurfaceArea = newDesk.Width * newDesk.Depth;

            DeskQuote.totalQuote = 200 + DeskQuote.SurfaceArea;

            Console.WriteLine(newDesk.NumberOfDrawers);

            //newDeskQuote.startCalculation();
        }

        private void width_Click(object sender, EventArgs e)
        {

        }

        public void widthTextbox_TextChanged(object sender, EventArgs e)
        {
            newDesk.Width = int.Parse(widthTextbox.Text);
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

        private void fullNameTextbox_Click(object sender, EventArgs e)
        {
            DeskQuote newDeskQuote = new DeskQuote();
            DeskQuote.FullName = fullNameTextbox.Text;
        }

        private void widthTextbox_Click(object sender, EventArgs e)
        {
            newDesk.Width = int.Parse(widthTextbox.Text);
        }
    }
}
