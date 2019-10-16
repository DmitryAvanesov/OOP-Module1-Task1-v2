using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace OOP_Module1_Task1_v2
{
    public partial class Form1 : Form
    {
        private readonly List<Planet> planets = new List<Planet>();
        private int labelPosition;
        private int selectedPlanet = -1;

        public Form1()
        {
            InitializeComponent();

            // fullscreen
            TopMost = true;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;

            labelPosition = 10;
        }

        public void AddPlanet(string name)
        {
            Planet newPlanet = new Planet(name, coloniesPanel, buildingsPanel,
                resourcesPanel, planetResourcesPanel);

            Label planetLabel = new Label
            {
                Text = string.Format("{0} | {1} km radius | x: {2}; y: {3}",
                newPlanet.Name,
                newPlanet.Radius,
                newPlanet.coordinates.X,
                newPlanet.coordinates.Y),

                Location = new Point(10, labelPosition),
                AutoSize = true,
                Name = planets.Count.ToString(),
                Font = new Font("Arial", 14)
            };

            planetLabel.Click += new EventHandler(SelectPlanet);
            newPlanet.Label = planetLabel;

            planets.Add(newPlanet);
            labelPosition += 30;
            planetsPanel.Controls.Add(planetLabel);
        }

        private void SelectPlanet(object sender, EventArgs e)
        {
            Label planetLabel = sender as Label;

            if (selectedPlanet != -1)
            {
                planets[selectedPlanet].Unselect();
            }
            selectedPlanet = int.Parse(planetLabel.Name);
            planets[selectedPlanet].Select();
        }

        private void AddPlanetButton_Click(object sender, EventArgs e)
        {
             AddPlanet(inputPlanetName.Text);
        }

        private void AddColonyButton_Click(object sender, EventArgs e)
        {
            if (selectedPlanet != -1)
            {
                planets[selectedPlanet].CreateColony(inputColonyName.Text);
            }
        }

        private void AddGoldmineButton_Click(object sender, EventArgs e)
        {
            if (selectedPlanet != -1 && planets[selectedPlanet].SelectedColony != -1)
            {
                planets[selectedPlanet].colonies
                    [planets[selectedPlanet].SelectedColony].CreateBuilding<Goldmine>
                    (planets[selectedPlanet].Storage, 50, 30);
            }
        }

        private void AddSawmillButton_Click(object sender, EventArgs e)
        {
            if (selectedPlanet != -1 && planets[selectedPlanet].SelectedColony != -1)
            {
                planets[selectedPlanet].colonies
                    [planets[selectedPlanet].SelectedColony].CreateBuilding<Sawmill>
                    (planets[selectedPlanet].Storage, 20, 100);
            }
        }
    }
}
