using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace OOP_Module1_Task1_v2
{
    class Colony : ISelectableObject
    {
        public bool IsSelected { get; set; }
        public Label Label { get; set; }

        public string name;
        private readonly List<Building> buildings = new List<Building>();
        private int labelPosition;
        private readonly Panel buildingsPanel;
        private readonly Planet planet;

        public Colony(string colonyName, Panel newBuildingsPanel, Planet thisPlanet)
        {
            IsSelected = false;
            name = colonyName;
            buildingsPanel = newBuildingsPanel;
            labelPosition = 10;
            planet = thisPlanet;
        }

        public void Unselect()
        {
            IsSelected = false;
            Label.BackColor = Color.Transparent;
            buildingsPanel.Controls.Clear();
        }

        public void Select()
        {
            IsSelected = true;
            Label.BackColor = Color.Beige;
            ShowBuildings();
        }

        public void CreateBuilding<T>(Storage storage, int goldCost, int woodCost)
            where T : Building, new()
        {
            if (storage.GetResource<Gold>().Amount >= goldCost &&
                storage.GetResource<Wood>().Amount >= woodCost)
            {
                T newBuilding = new T
                {
                    Storage = storage,
                    Planet = planet
                };

                Label buildingLabel = new Label
                {
                    Text = string.Format("{0} | x: {1}; y: {2}",
                    newBuilding.Name,
                    newBuilding.coordinates.X,
                    newBuilding.coordinates.Y),

                    Location = new Point(10, labelPosition),
                    AutoSize = true,
                    Name = buildings.Count.ToString(),
                    Font = new Font("Arial", 14)
                };

                buildings.Add(newBuilding);
                buildingsPanel.Controls.Add(buildingLabel);
                labelPosition += 30;

                storage.Pay<Gold>(goldCost);
                storage.Pay<Wood>(woodCost);
            }
        }

        public void ShowBuildings()
        {
            labelPosition = 10;

            for (int currentBuilding = 0; currentBuilding < buildings.Count; currentBuilding++)
            {
                Label buildingLabel = new Label
                {
                    Text = string.Format("{0} | x: {1}; y: {2}",
                    buildings[currentBuilding].Name,
                    buildings[currentBuilding].coordinates.X,
                    buildings[currentBuilding].coordinates.Y),

                    Location = new Point(10, labelPosition),
                    AutoSize = true,
                    Name = currentBuilding.ToString(),
                    Font = new Font("Arial", 14)
                };

                labelPosition += 30;
                buildingsPanel.Controls.Add(buildingLabel);
            }
        }
    }
}
