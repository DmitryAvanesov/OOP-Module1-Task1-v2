using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Module1_Task1_v2
{
    class Planet : MapObject, SelectableObject
    {
        public bool IsSelected { get; set; }
        public string Name { get; }
        public Coordinates Coordinates { get; }
        public int Radius { get; }

        private List<Colony> colonies = new List<Colony>();
        private List<Resource> resources = new List<Resource>();

        public Planet(string newName)
        {
            IsSelected = false;
            Name = newName;

            Random random = new Random();
            Coordinates = new Coordinates(random.Next(-10000, 10000), random.Next(-10000, 10000));
            Radius = random.Next(10, 1000);
        }

        public void ChangeSelectionState()
        {
            if (IsSelected)
            {
                IsSelected = false;
            }
            else
            {
                IsSelected = true;
            }
        }

        public void CreateColony(string colonyName)
        {
            colonies.Add(new Colony(colonyName));
        }

        public void ShowColonies()
        {
            Console.WriteLine("{0} colonies:", Name);

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
