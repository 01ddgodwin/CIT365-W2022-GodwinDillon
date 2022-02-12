using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MegaDesk;

namespace MegaDesk
{
    public class Desk
    {
        public enum material
        {
            Laminate,
            Oak,
            Rosewood,
            Veneer,
            Pine
        }

        public int Width;
        public int Depth;
        public int NumberOfDrawers;
        public string? Material;


        public const int MinWidth = 24;
        public const int MaxWidth = 96;
        public const int MinDepth = 28;
        public const int MaxDepth = 48;
        public const int MinDrawers = 0;
        public const int MaxDrawers = 7;

    }
}
