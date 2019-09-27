using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Module1_Task1_v2
{
    class Resource : MapObject
    {
        private int amount;
        private string type;

        public Resource()
        {
            coordinates = new Coordinates(0, 0);
        }

        public int Amount
        {
            get
            {
                return amount;
            }
        }

        public string Type
        {
            get
            {
                return type;
            }
        }
    }
}
