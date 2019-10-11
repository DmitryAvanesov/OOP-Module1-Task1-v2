using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace OOP_Module1_Task1_v2
{
    class Colony : ISelectableObject
    {
        public string name;
        private readonly List<Goldmine> goldmines = new List<Goldmine>();
        private readonly List<Sawmill> sawmills = new List<Sawmill>();
        public bool IsSelected { get; set; }
        public Label Label { get; set; }
        private int labelPosition = 10;
        public Panel ColoniesPanel { get; set; }
        public Panel BuildingsPanel { get; set; }

        public Colony(string colonyName)
        {
            IsSelected = false;
            name = colonyName;
        }

        public void Unselect()
        {
            IsSelected = false;
            Label.BackColor = Color.Transparent;
            BuildingsPanel.Controls.Clear();
        }

        public void Select()
        {
            IsSelected = true;
            Label.BackColor = Color.Beige;
            ShowBuildings();
        }

        public void CreateGoldmine(string buildingName, Budget mainBudget)
        {
            if (mainBudget.goldAmount >= 50 && mainBudget.woodAmount >= 30)
            {
                goldmines.Add(new Goldmine(buildingName, mainBudget));

                Label buildingLabel = new Label
                {
                    Text = string.Format("{0} | Goldmine | x: {1}; y: {2}",
                    goldmines[goldmines.Count - 1].name,
                    goldmines[goldmines.Count - 1].coordinates.X,
                    goldmines[goldmines.Count - 1].coordinates.Y),

                    Location = new Point(10, labelPosition),
                    AutoSize = true,
                    Name = (goldmines.Count - 1).ToString(),
                    Font = new Font("Arial", 14)
                };
                labelPosition += 30;

                BuildingsPanel.Controls.Add(buildingLabel);
                mainBudget.DecreaseBudget(50, 30);
            }
        }

        public void CreateSawmill(string buildingName, Budget mainBudget)
        {
            if (mainBudget.goldAmount >= 20 && mainBudget.woodAmount >= 100)
            {
                sawmills.Add(new Sawmill(buildingName, mainBudget));

                Label buildingLabel = new Label
                {
                    Text = string.Format("{0} | Sawmill | x: {1}; y: {2}",
                    sawmills[sawmills.Count - 1].name,
                    sawmills[sawmills.Count - 1].coordinates.X,
                    sawmills[sawmills.Count - 1].coordinates.Y),

                    Location = new Point(10, labelPosition),
                    AutoSize = true,
                    Name = (sawmills.Count - 1).ToString(),
                    Font = new Font("Arial", 14)
                };
                labelPosition += 30;

                BuildingsPanel.Controls.Add(buildingLabel);
                mainBudget.DecreaseBudget(20, 100);
            }
        }

        public void ShowBuildings()
        {
            labelPosition = 10;

            for (int currentBuilding = 0; currentBuilding < goldmines.Count; currentBuilding++)
            {
                Label buildingLabel = new Label
                {
                    Text = string.Format("{0} | Goldmine | x: {1}; y: {2}",
                    goldmines[goldmines.Count - 1].name,
                    goldmines[goldmines.Count - 1].coordinates.X,
                    goldmines[goldmines.Count - 1].coordinates.Y),

                    Location = new Point(10, labelPosition),
                    AutoSize = true,
                    Name = currentBuilding.ToString(),
                    Font = new Font("Arial", 14)
                };

                labelPosition += 30;
                BuildingsPanel.Controls.Add(buildingLabel);
            }

            for (int currentBuilding = 0; currentBuilding < sawmills.Count; currentBuilding++)
            {
                Label buildingLabel = new Label
                {
                    Text = string.Format("{0} | Sawmill | x: {1}; y: {2}",
                    sawmills[sawmills.Count - 1].name,
                    sawmills[sawmills.Count - 1].coordinates.X,
                    sawmills[sawmills.Count - 1].coordinates.Y),

                    Location = new Point(10, labelPosition),
                    AutoSize = true,
                    Name = currentBuilding.ToString(),
                    Font = new Font("Arial", 14)
                };

                labelPosition += 30;
                BuildingsPanel.Controls.Add(buildingLabel);
            }
        }
    }
}
