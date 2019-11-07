using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Module1_Task1_v2
{
    class UserInterface
    {
        private int planetLabelPosition;
        private int colonyLabelPosition;
        private int buildingLabelPosition;
        private int planetResourcesLabelPosition;
        private int resourcesLabelPosition;
        private Panel planetsPanel;
        private Panel coloniesPanel;
        private Panel buildingsPanel;
        private Panel planetResourcesPanel;
        private Panel resourcesPanel;

        public UserInterface(Panel newPlanetsPanel, Panel newColoniesPanel,
            Panel newBuildingsPanel, Panel newPlanetResourcesPanel, Panel newResourcesPanel)
        {
            planetLabelPosition = 10;
            colonyLabelPosition = 10;
            buildingLabelPosition = 10;

            planetsPanel = newPlanetsPanel;
            coloniesPanel = newColoniesPanel;
            buildingsPanel = newBuildingsPanel;
            planetResourcesPanel = newPlanetResourcesPanel;
            resourcesPanel = newResourcesPanel;
        }

        public void OnAddPlanet(Planet newPlanet)
        {
            Label planetLabel = new Label
            {
                Text = string.Format("{0} | {1} km radius | x: {2}; y: {3}",
                newPlanet.Name,
                newPlanet.Radius,
                newPlanet.coordinates.X,
                newPlanet.coordinates.Y),

                Location = new Point(10, planetLabelPosition),
                AutoSize = true,
                Name = newPlanet.Number.ToString(),
                Font = new Font("Arial", 14)
            };

            planetLabel.Click += new EventHandler(
                (sender, e) => SelectPlanetWrapper(sender, e, newPlanet));

            planetLabelPosition += 30;
            planetsPanel.Controls.Add(planetLabel);
        }

        private void SelectPlanetWrapper(object sender, EventArgs e, Planet newPlanet)
        {
            newPlanet.Form.SelectPlanet(sender);
        }

        public void OnUnselectPlanet(int planetNumber)
        {
            planetsPanel.Controls[planetNumber].BackColor = Color.Transparent;
            coloniesPanel.Controls.Clear();
            buildingsPanel.Controls.Clear();
        }

        public void OnSelectPlanet(int planetNumber)
        {
            planetsPanel.Controls[planetNumber].BackColor = Color.Beige;
        }

        public void OnCreateColony(Colony newColony)
        {
            Label colonyLabel = new Label
            {
                Text = string.Format("{0}",
                newColony.Name),

                Location = new Point(10, colonyLabelPosition),
                AutoSize = true,
                Name = newColony.Number.ToString(),
                Font = new Font("Arial", 14)
            };

            colonyLabel.Click += new EventHandler(
                (sender, e) => SelectColonyWrapper(sender, e, newColony));
            coloniesPanel.Controls.Add(colonyLabel);
            colonyLabelPosition += 30;
        }

        private void SelectColonyWrapper(object sender, EventArgs e, Colony newColony)
        {
            newColony.Planet.SelectColony(sender);
        }

        public void ShowColonies(IList<Colony> colonies)
        {
            colonyLabelPosition = 10;

            for (int currentColony = 0; currentColony < colonies.Count; currentColony++)
            {
                Label colonyLabel = new Label
                {
                    Text = string.Format("{0}",
                    colonies[currentColony].Name),

                    Location = new Point(10, colonyLabelPosition),
                    AutoSize = true,
                    Name = currentColony.ToString(),
                    Font = new Font("Arial", 14)
                };

                colonyLabel.Click += new EventHandler(
                    (sender, e) => SelectColonyWrapper(sender, e, colonies[currentColony - 1]));

                colonyLabelPosition += 30;
                coloniesPanel.Controls.Add(colonyLabel);
            }
        }

        public void OnUnselectColony(int colonyNumber) {
            coloniesPanel.Controls[colonyNumber].BackColor = Color.Transparent;
            buildingsPanel.Controls.Clear();
        }

        public void OnSelectColony(int colonyNumber)
        {
            coloniesPanel.Controls[colonyNumber].BackColor = Color.Beige;
        }

        public void ShowPlanetResources(Dictionary<Type, Resource> planetResources)
        {
            planetResourcesPanel.Controls.Clear();
            planetResourcesLabelPosition = 10;

            foreach (var resource in planetResources)
            {
                Label resourcesLabel = new Label
                {
                    Text = string.Format("({0} more left)",
                    resource.Value.Amount),

                    Location = new Point(10, planetResourcesLabelPosition),
                    AutoSize = true,
                    Font = new Font("Arial", 14)
                };

                planetResourcesPanel.Controls.Add(resourcesLabel);
                planetResourcesLabelPosition += 30;
            }
        }

        public void OnCreateBuilding(Building newBuilding)
        {
            Label buildingLabel = new Label
            {
                Text = string.Format("{0} | x: {1}; y: {2}",
                    newBuilding.Name,
                    newBuilding.coordinates.X,
                    newBuilding.coordinates.Y),

                Location = new Point(10, buildingLabelPosition),
                AutoSize = true,
                Name = newBuilding.Number.ToString(),
                Font = new Font("Arial", 14)
            };

            buildingsPanel.Controls.Add(buildingLabel);
            buildingLabelPosition += 30;
        }

        public void ShowBuildings(IList<Building> Buildings)
        {
            buildingLabelPosition = 10;

            foreach (var currentBuilding in Buildings)
            {
                Label buildingLabel = new Label
                {
                    Text = string.Format("{0} | x: {1}; y: {2}",
                    currentBuilding.Name,
                    currentBuilding.coordinates.X,
                    currentBuilding.coordinates.Y),

                    Location = new Point(10, buildingLabelPosition),
                    AutoSize = true,
                    Name = currentBuilding.ToString(),
                    Font = new Font("Arial", 14)
                };

                buildingLabelPosition += 30;
                buildingsPanel.Controls.Add(buildingLabel);
            }
        }

        public void ShowResources(Dictionary<Type, Resource> resources)
        {
            resourcesPanel.Controls.Clear();
            resourcesLabelPosition = 10;

            foreach (var resource in resources)
            {
                Label resourcesLabel = new Label
                {
                    Text = string.Format("{0}: {1}",
                    resource.Value.Name,
                    resource.Value.Amount),

                    Location = new Point(10, resourcesLabelPosition),
                    AutoSize = true,
                    Font = new Font("Arial", 14)
                };

                resourcesPanel.Controls.Add(resourcesLabel);
                resourcesLabelPosition += 30;
            }
        }
    }
}
