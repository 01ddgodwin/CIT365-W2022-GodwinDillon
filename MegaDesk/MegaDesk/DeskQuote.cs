using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MegaDesk;

namespace MegaDesk
{
    public class DeskQuote
    {
        Desk newDesk = new Desk();
        public static string FullName;
        int RushDays;
        public static int SurfaceArea;
        public static int totalQuote;

        public void startCalculation()
        {
            //DisplayQuote newDisplayQuote = new DisplayQuote();
            //Desk newDesk = new Desk();
            //newDesk.FullName= AddQuote.fullNameTextbox.Text;
            //newDisplayQuote.FullNameInputLabel.Text = newDesk.FullName.ToString();

            //AddQuote newQuote = new AddQuote();
            //newDisplayQuote.WidthInputLabel.Text = newQuote.widthTextbox.Text.ToString();

            //DisplayQuote newDisplayQuote = new DisplayQuote();
            //Desk newDesk = new Desk();
            //string text = Desk.FullName;
            //newDisplayQuote.FullNameInputLabel.Text = text;
            //Console.WriteLine(newDesk);

            //AddQuote newAddQuote = new AddQuote();
            //FullName = newAddQuote.fullNameTextbox.Text;
            DisplayQuote newDisplayQuote = new DisplayQuote();
            newDisplayQuote.FullNameInputLabel.Text = FullName;
            //newDisplayQuote.WidthInputLabel.Text = Width;

            Console.WriteLine(newDesk.Width);



        }
    }
}