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
        public Label Label { get; set; }

        private readonly Panel coloniesPanel;
        private readonly Panel buildingsPanel;

        public List<Colony> colonies = new List<Colony>();
        private int selectedColony = 0;
        public Dictionary<Type, Resource> resources = new Dictionary<Type, Resource>();
        public Storage Storage { get; }

        private int labelPosition;

        public Planet(string newName, Panel newColoniesPanel, Panel newBuildingsPanel)
        {
            IsSelected = false;
            Name = newName;
            coloniesPanel = newColoniesPanel;
            buildingsPanel = newBuildingsPanel;

            Random random = new Random();
            coordinates = new Coordinates(random.Next(-10000, 10000), random.Next(-10000, 10000));
            Radius = random.Next(10, 1000);

            resources[typeof(Gold)] = new Gold(Radius);
            resources[typeof(Wood)] = new Wood(Radius * 2);
        }

        public void Unselect()
        {
            IsSelected = false;
            Label.BackColor = Color.Transparent;
            coloniesPanel.Controls.Clear();
            buildingsPanel.Controls.Clear();

            if (colonies.Count > 0)
            {
                colonies[selectedColony].Unselect();
            }
        }

        public void Select()
        {
            IsSelected = true;
            Label.BackColor = Color.Beige;
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
                    Name = currentColony.ToString(),
                    Font = new Font("Arial", 14)
                };

                colonyLabel.Click += new EventHandler(SelectColony);
                colonies[currentColony].Label = colonyLabel;

                labelPosition += 30;
                coloniesPanel.Controls.Add(colonyLabel);
            }
        }

        private void SelectColony(object sender, EventArgs e)
        {
            Label colonyLabel = sender as Label;
            colonies[selectedColony].Unselect();
            selectedColony = int.Parse(colonyLabel.Name);
            colonies[selectedColony].Select();
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
                Name = (colonies.Count - 1).ToString(),
                Font = new Font("Arial", 14)
            };

            colonies[colonies.Count - 1].Label = colonyLabel;
            colonies[colonies.Count - 1].ColoniesPanel = coloniesPanel;
            colonies[colonies.Count - 1].BuildingsPanel = buildingsPanel;

            colonyLabel.Click += new EventHandler(SelectColony);

            labelPosition += 30;
            coloniesPanel.Controls.Add(colonyLabel);
        }
    }
}
