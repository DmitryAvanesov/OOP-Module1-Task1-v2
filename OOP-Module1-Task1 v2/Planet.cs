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
        public int SelectedColony { get; private set; }
        public Storage Storage { get; }

        private readonly Panel coloniesPanel;
        private readonly Panel buildingsPanel;
        private readonly Panel resourcesPanel;
        public List<Colony> colonies = new List<Colony>();
        public Dictionary<Type, Resource> planetResources = new Dictionary<Type, Resource>();
        private int labelPosition;

        public Planet(string newName, Panel newColoniesPanel,
            Panel newBuildingsPanel, Panel newResourcesPanel)
        {
            IsSelected = false;
            Name = newName;
            coloniesPanel = newColoniesPanel;
            buildingsPanel = newBuildingsPanel;
            resourcesPanel = newResourcesPanel;

            Random random = new Random();
            coordinates = new Coordinates(random.Next(-10000, 10000), random.Next(-10000, 10000));
            Radius = random.Next(10, 1000);

            planetResources[typeof(Gold)] = new Gold(Radius);
            planetResources[typeof(Wood)] = new Wood(Radius * 2);

            Storage = new Storage(400, 900, resourcesPanel);
            Storage.resources[typeof(Gold)] = new Gold(400);
            Storage.resources[typeof(Wood)] = new Wood(900);
        }

        public void Unselect()
        {
            IsSelected = false;
            Label.BackColor = Color.Transparent;
            coloniesPanel.Controls.Clear();
            buildingsPanel.Controls.Clear();

            if (colonies.Count > 0)
            {
                colonies[SelectedColony].Unselect();
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
            colonies[SelectedColony].Unselect();
            SelectedColony = int.Parse(colonyLabel.Name);
            colonies[SelectedColony].Select();
        }

        public void CreateColony(string colonyName)
        {
            Colony newColony = new Colony(colonyName, buildingsPanel);

            Label colonyLabel = new Label
            {
                Text = string.Format("{0}",
                newColony.name),

                Location = new Point(10, labelPosition),
                AutoSize = true,
                Name = colonies.Count.ToString(),
                Font = new Font("Arial", 14)
            };

            colonyLabel.Click += new EventHandler(SelectColony);
            newColony.Label = colonyLabel;

            colonies.Add(newColony);
            coloniesPanel.Controls.Add(colonyLabel);
            labelPosition += 30;
        }
    }
}
