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
        private int labelPosition;
        public Label label { get; set; }

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

        public void Unselect (Panel coloniesPanel)
        {
            IsSelected = false;
            label.BackColor = System.Drawing.Color.Transparent;
            coloniesPanel.Controls.Clear();
        }

        public void Select(Panel coloniesPanel)
        {
            IsSelected = true;
            label.BackColor = System.Drawing.Color.Beige;
            ShowColonies(coloniesPanel);
        }

        private void ShowColonies(Panel coloniesPanel)
        {
            labelPosition = 10;

            for (int currentColony = 0; currentColony < colonies.Count; currentColony++)
            {
                Label colonyLabel = new Label
                {
                    Text = string.Format("{0}",
                    colonies[currentColony].name),

                    Location = new Point(10, labelPosition),
                    AutoSize = true,
                    Name = currentColony.ToString()
                };

                colonyLabel.Click += new EventHandler(SelectColony);

                labelPosition += 20;
                coloniesPanel.Controls.Add(colonyLabel);
            }
        }

        private void SelectColony(object sender, EventArgs e)
        {
            
        }

        public void CreateColony(string colonyName, Panel coloniesPanel)
        {
            colonies.Add(new Colony(colonyName));

            Label colonyLabel = new Label
            {
                Text = string.Format("{0}",
                colonies[colonies.Count - 1].name),

                Location = new Point(10, labelPosition),
                AutoSize = true,
                Name = (colonies.Count - 1).ToString()
            };
            labelPosition += 20;

            coloniesPanel.Controls.Add(colonyLabel);
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
