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
    public partial class DisplayQuote : Form
    {
        public DisplayQuote()
        {
            InitializeComponent();
        }

        private void backToMainMenu_Click(object sender, EventArgs e)
        {
            AddQuote viewAddQuote = (AddQuote)Tag;
            viewAddQuote.Show();
            Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void AreaLabel_Click(object sender, EventArgs e)
        {

        }

        public void FullNameInputLabel_Click(object sender, EventArgs e)
        {
            
        }

        public void FullNameLabel_Click(object sender, EventArgs e)
        {

        }

        private void WidthLabel_Click(object sender, EventArgs e)
        {

        }

        private void DepthLabel_Click(object sender, EventArgs e)
        {

        }

        private void FullNameInputLabel_TextChanged(object sender, EventArgs e)
        {
            //FullNameInputLabel.Text = DeskQuote.FullName;
        }

        private void FullNameInputLabel_MouseMove(object sender, MouseEventArgs e)
        {
            FullNameInputLabel.Text = DeskQuote.FullName;
        }

        private void WidthInputLabel_MouseMove(object sender, EventArgs e)
        {
            
        }

        private void WidthInputLabel_MouseMove(object sender, MouseEventArgs e)
        {
            Desk newDesk = new Desk();
            WidthInputLabel.Text = newDesk.Width.ToString();
            Console.WriteLine(WidthInputLabel.Text);
        }
    }
}
