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
        private readonly Panel planetResourcesPanel;
        public List<Colony> colonies = new List<Colony>();
        public Dictionary<Type, Resource> planetResources = new Dictionary<Type, Resource>();
        public int labelPosition;

        public Planet(string newName, Panel newColoniesPanel,
            Panel newBuildingsPanel, Panel newResourcesPanel,
            Panel newPlanetResourcesPanel)
        {
            IsSelected = false;
            Name = newName;
            coloniesPanel = newColoniesPanel;
            buildingsPanel = newBuildingsPanel;
            resourcesPanel = newResourcesPanel;
            planetResourcesPanel = newPlanetResourcesPanel;
            SelectedColony = -1;
            labelPosition = 10;

            Random random = new Random();
            coordinates = new Coordinates(random.Next(-10000, 10000), random.Next(-10000, 10000));
            Radius = random.Next(100, 1000);

            planetResources[typeof(Gold)] = new Gold(Radius +
                random.Next(-Radius / 3, Radius / 3));
            planetResources[typeof(Wood)] = new Wood(Radius +
                random.Next(-Radius / 2, Radius / 2));

            Storage = new Storage(400, 900, resourcesPanel);
        }

        public void Unselect()
        {
            IsSelected = false;
            Label.BackColor = Color.Transparent;
            coloniesPanel.Controls.Clear();
            buildingsPanel.Controls.Clear();

            if (SelectedColony != -1)
            {
                colonies[SelectedColony].Unselect();
                SelectedColony = -1;
            }
        }

        public void Select()
        {
            IsSelected = true;
            Label.BackColor = Color.Beige;
            ShowColonies();
            Storage.ShowResources();
            ShowPlanetResources();
        }

        public void CreateColony(string colonyName)
        {
            Colony newColony = new Colony(colonyName, buildingsPanel, this);

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

            if (SelectedColony != -1)
            {
                colonies[SelectedColony].Unselect();
            }
            SelectedColony = int.Parse(colonyLabel.Name);
            colonies[SelectedColony].Select();
        }

        public void ExtractResources<T>(int amount)
        {
            planetResources[typeof(T)].Amount -= amount;
        }

        public void ShowPlanetResources()
        {
            planetResourcesPanel.Controls.Clear();
            labelPosition = 10;

            foreach (var resource in planetResources)
            {
                Label resourcesLabel = new Label
                {
                    Text = string.Format("({0} more left)",
                    resource.Value.Amount),

                    Location = new Point(10, labelPosition),
                    AutoSize = true,
                    Font = new Font("Arial", 14)
                };

                planetResourcesPanel.Controls.Add(resourcesLabel);
                labelPosition += 30;
            }
        }
    }
}
