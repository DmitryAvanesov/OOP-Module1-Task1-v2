using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Module1_Task1_v2
{
    class Colony
    {
        public string name;
        private List<Building> buildings = new List<Building>();

        public Colony(string colonyName)
        {
            name = colonyName;
        }
    }
}
