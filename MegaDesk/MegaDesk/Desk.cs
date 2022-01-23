using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MegaDesk
{
    public enum drawers
    {
        zero = 0,
        one = 1,
        two = 2,
        three = 3,
        four = 4,
        five = 5,
        six = 6,
        seven = 7
    }

    public enum material
    {
        Laminate,
        Oak,
        Rosewood,
        Veneer,
        Pine
    }

    public enum rushOptions
    {
        three = 3,
        five = 5,
        seven = 7
    }
    public class Desk
    {
        public string? FullName { get; set; }
        public int Width { get; set; }

        public int Depth { get; set; }
        public int NumberOfDrawers { get; set; }
        public string? Material { get; set; }


        public const int MINWIDTH = 24;
        public const int MAXWIDTH = 96;
        public const int MINDEPTH = 28;
        public const int MAXDEPTH = 48;
        public const int MINNUMOFDRAWERS = 0;
        public const int MAXNUMOFDRAWERS = 7;

    }
}
