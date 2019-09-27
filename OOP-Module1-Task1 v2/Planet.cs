using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Module1_Task1_v2
{
    class Planet : MapObject
    {
        private string name;
        private List<Colony> colonies = new List<Colony>();
        private List<Resource> resources = new List<Resource>();

        public Planet(string newName, Coordinates newCoord)
        {
            name = newName;
            coordinates = newCoord;
        }

        public string Name
        {
            get
            {
                return name;
            }
        }

        public Coordinates Coordinates
        {
            get
            {
                return coordinates;
            }
        }

        public void CreateColony(string colonyName)
        {
            colonies.Add(new Colony(colonyName));
        }

        public void ShowColonies()
        {
            Console.WriteLine("{0} colonies:", name);

            for (int i = 0; i < colonies.Count; i++)
            {
                Console.WriteLine(colonies[i].name);
            }

            Console.WriteLine();
        }
        public void ShowResources()
        {
            for (int i = 0; i < resources.Count; i++)
            {
                Console.WriteLine("{0} units of resource of type {1}", resources[i].Amount, resources[i].Type);
            }
        }
    }
}
