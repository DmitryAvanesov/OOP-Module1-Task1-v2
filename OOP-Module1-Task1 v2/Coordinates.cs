using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Module1_Task1_v2
{
    class Coordinates
    {
        private int x;
        private int y;

        public Coordinates(int xCoord, int yCoord)
        {
            x = xCoord;
            y = yCoord;
        }

        public int X
        {
            get;
        }

        public int Y
        {
            get;
        }
    }
}
