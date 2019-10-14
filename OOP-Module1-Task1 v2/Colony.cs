using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace OOP_Module1_Task1_v2
{
    class Colony : ISelectableObject
    {
        public string name;
        private readonly List<Building> buildings = new List<Building>();
        public bool IsSelected { get; set; }
        public Label Label { get; set; }

        private int labelPosition = 10;
        private Panel buildingsPanel;

        public Colony(string colonyName, Panel newBuildingsPanel)
        {
            IsSelected = false;
            name = colonyName;
            buildingsPanel = newBuildingsPanel;
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
                    Storage = storage
                };

                Label buildingLabel = new Label
                {
                    Text = string.Format("Goldmine | x: {0}; y: {1}",
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
                    Text = string.Format("x: {0}; y: {1}",
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
