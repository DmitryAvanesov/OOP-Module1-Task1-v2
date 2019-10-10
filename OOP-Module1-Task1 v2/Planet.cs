using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace OOP_Module1_Task1_v2
{
    class Planet : MapObject, ISelectableObject
    {
        public bool IsSelected { get; set; }
        public string Name { get; }
        public int Radius { get; }
        private int labelPosition;
        public Label Label { get; set; }
        public Panel ColoniesPanel { get; set; }
        public Panel BuildingsPanel { get; set; }

        public List<Colony> colonies = new List<Colony>();
        private List<Resource> resources = new List<Resource>();

        public Planet(string newName)
        {
            IsSelected = false;
            Name = newName;

            Random random = new Random();
            coordinates = new Coordinates(random.Next(-10000, 10000), random.Next(-10000, 10000));
            Radius = random.Next(10, 1000);
        }

        public void Unselect ()
        {
            IsSelected = false;
            Label.BackColor = System.Drawing.Color.Transparent;
            ColoniesPanel.Controls.Clear();
            BuildingsPanel.Controls.Clear();

            for (int currentColony = 0; currentColony < colonies.Count; currentColony++)
            {
                if (colonies[currentColony].IsSelected)
                {
                    colonies[currentColony].Unselect();
                    break;
                }
            }
        }

        public void Select()
        {
            IsSelected = true;
            Label.BackColor = System.Drawing.Color.Beige;
            ShowColonies();
        }

        private void ShowColonies()
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
                colonies[currentColony].Label = colonyLabel;

                labelPosition += 20;
                ColoniesPanel.Controls.Add(colonyLabel);
            }
        }

        private void SelectColony(object sender, EventArgs e)
        {
            Label colonyLabel = sender as Label;

            for (int currentColony = 0; currentColony < colonies.Count; currentColony++)
            {
                if (colonies[currentColony].IsSelected)
                {
                    colonies[currentColony].Unselect();
                    break;
                }
            }

            for (int currentColony = 0; currentColony < colonies.Count; currentColony++)
            {
                if (currentColony == int.Parse(colonyLabel.Name))
                {
                    colonies[currentColony].Select();
                    break;
                }
            }
        }

        public void CreateColony(string colonyName)
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

            colonies[colonies.Count - 1].Label = colonyLabel;
            colonies[colonies.Count - 1].ColoniesPanel = ColoniesPanel;
            colonies[colonies.Count - 1].BuildingsPanel = BuildingsPanel;

            colonyLabel.Click += new EventHandler(SelectColony);

            labelPosition += 20;
            ColoniesPanel.Controls.Add(colonyLabel);
        }
    }
}
