using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace OOP_Module1_Task1_v2
{
    class UserInterface
    {
        const int InitialMargin = 10;
        const int StepMargin = 30;
        const int FontSize = 11;

        private int _planetLabelPosition;
        private int _colonyLabelPosition;
        private int _buildingLabelPosition;
        private int _planetResourcesLabelPosition;
        private int _resourcesLabelPosition;
        private readonly Panel _planetsPanel;
        private readonly Panel _coloniesPanel;
        private readonly Panel _buildingsPanel;
        private readonly Panel _planetResourcesPanel;
        private readonly Panel _resourcesPanel;

        public UserInterface(Panel newPlanetsPanel, Panel newColoniesPanel,
            Panel newBuildingsPanel, Panel newPlanetResourcesPanel, Panel newResourcesPanel)
        {
            _planetLabelPosition = InitialMargin;
            _colonyLabelPosition = InitialMargin;
            _buildingLabelPosition = InitialMargin;
            _planetResourcesLabelPosition = InitialMargin;
            _resourcesLabelPosition = InitialMargin;

        _planetsPanel = newPlanetsPanel;
            _coloniesPanel = newColoniesPanel;
            _buildingsPanel = newBuildingsPanel;
            _planetResourcesPanel = newPlanetResourcesPanel;
            _resourcesPanel = newResourcesPanel;
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

                Location = new Point(InitialMargin, _planetLabelPosition),
                AutoSize = true,
                Name = newPlanet.Number.ToString(),
                Font = new Font("Arial", FontSize)
            };

            planetLabel.Click += new EventHandler(
                (sender, e) => SelectPlanetWrapper(sender, e, newPlanet));

            _planetLabelPosition += StepMargin;
            _planetsPanel.Controls.Add(planetLabel);
        }

        private void SelectPlanetWrapper(object sender, EventArgs _, Planet newPlanet)
        {
            newPlanet.Form.SelectPlanet(sender);
        }

        public void OnUnselectPlanet(int planetNumber)
        {
            _planetsPanel.Controls[planetNumber].BackColor = Color.Transparent;
            _coloniesPanel.Controls.Clear();
            _buildingsPanel.Controls.Clear();
        }

        public void OnSelectPlanet(int planetNumber)
        {
            _planetsPanel.Controls[planetNumber].BackColor = Color.Beige;
        }

        public void OnCreateColony(Colony newColony)
        {
            Label colonyLabel = new Label
            {
                Text = string.Format("{0}",
                newColony.Name),

                Location = new Point(InitialMargin, _colonyLabelPosition),
                AutoSize = true,
                Name = newColony.Number.ToString(),
                Font = new Font("Arial", FontSize)
            };

            colonyLabel.Click += new EventHandler(
                (sender, e) => SelectColonyWrapper(sender, e, newColony));
            _coloniesPanel.Controls.Add(colonyLabel);
            _colonyLabelPosition += StepMargin;
        }

        private void SelectColonyWrapper(object sender, EventArgs _, Colony newColony)
        {
            newColony.Planet.SelectColony(sender);
        }

        public void ShowColonies(IList<Colony> colonies)
        {
            _colonyLabelPosition = InitialMargin;

            for (int currentColony = 0; currentColony < colonies.Count; currentColony++)
            {
                Label colonyLabel = new Label
                {
                    Text = string.Format("{0}",
                    colonies[currentColony].Name),

                    Location = new Point(InitialMargin, _colonyLabelPosition),
                    AutoSize = true,
                    Name = currentColony.ToString(),
                    Font = new Font("Arial", FontSize)
                };

                colonyLabel.Click += new EventHandler(
                    (sender, e) => SelectColonyWrapper(sender, e, colonies[currentColony - 1]));

                _colonyLabelPosition += StepMargin;
                _coloniesPanel.Controls.Add(colonyLabel);
            }
        }

        public void OnUnselectColony(int colonyNumber) {
            _coloniesPanel.Controls[colonyNumber].BackColor = Color.Transparent;
            _buildingsPanel.Controls.Clear();
        }

        public void OnSelectColony(int colonyNumber)
        {
            _coloniesPanel.Controls[colonyNumber].BackColor = Color.Beige;
        }

        public void ShowPlanetResources(Dictionary<Type, Resource> planetResources)
        {
            _planetResourcesPanel.Controls.Clear();
            _planetResourcesLabelPosition = InitialMargin;

            foreach (var resource in planetResources)
            {
                Label resourcesLabel = new Label
                {
                    Text = string.Format("({0} more left)",
                    resource.Value.Amount),

                    Location = new Point(InitialMargin, _planetResourcesLabelPosition),
                    AutoSize = true,
                    Font = new Font("Arial", FontSize)
                };

                _planetResourcesPanel.Controls.Add(resourcesLabel);
                _planetResourcesLabelPosition += StepMargin;
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

                Location = new Point(InitialMargin, _buildingLabelPosition),
                AutoSize = true,
                Name = newBuilding.Number.ToString(),
                Font = new Font("Arial", FontSize)
            };

            _buildingsPanel.Controls.Add(buildingLabel);
            _buildingLabelPosition += StepMargin;
        }

        public void ShowBuildings(IList<Building> Buildings)
        {
            _buildingLabelPosition = InitialMargin;

            foreach (var currentBuilding in Buildings)
            {
                Label buildingLabel = new Label
                {
                    Text = string.Format("{0} | x: {1}; y: {2}",
                    currentBuilding.Name,
                    currentBuilding.coordinates.X,
                    currentBuilding.coordinates.Y),

                    Location = new Point(InitialMargin, _buildingLabelPosition),
                    AutoSize = true,
                    Name = currentBuilding.ToString(),
                    Font = new Font("Arial", FontSize)
                };

                _buildingLabelPosition += StepMargin;
                _buildingsPanel.Controls.Add(buildingLabel);
            }
        }

        public void ShowResources(Dictionary<Type, Resource> resources)
        {
            _resourcesPanel.Controls.Clear();
            _resourcesLabelPosition = InitialMargin;

            foreach (var resource in resources)
            {
                Label resourcesLabel = new Label
                {
                    Text = string.Format("{0}: {1}",
                    resource.Value.Name,
                    resource.Value.Amount),

                    Location = new Point(InitialMargin, _resourcesLabelPosition),
                    AutoSize = true,
                    Font = new Font("Arial", FontSize)
                };

                _resourcesPanel.Controls.Add(resourcesLabel);
                _resourcesLabelPosition += StepMargin;
            }
        }
    }
}
