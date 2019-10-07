using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Module1_Task1_v2
{
    class Building : MapObject
    {
        private int gold;
        private int wood;

        public Building()
        {
            coordinates = new Coordinates(0, 0);
        }

        public void GetResources()
        {
            // todo
        }
    }
}
