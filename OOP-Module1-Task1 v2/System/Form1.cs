using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace OOP_Module1_Task1_v2
{
    public partial class Form1 : Form
    {
        private UserInterface formUI;
        private readonly IList<Planet> planets = new List<Planet>();
        private int selectedPlanet = -1;

        public Form1()
        {
            InitializeComponent();

            formUI = new UserInterface(planetsPanel, coloniesPanel,
                buildingsPanel, planetResourcesPanel, resourcesPanel);
        }

        public void AddPlanet(string name)
        {
            Planet newPlanet = new Planet(name, formUI, planets.Count, this);
            formUI.OnAddPlanet(newPlanet);
            planets.Add(newPlanet);
        }

        public void SelectPlanet(object sender)
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
                    (new ResourceBox(50, 20, formUI));
            }
        }

        private void AddSawmillButton_Click(object sender, EventArgs e)
        {
            if (selectedPlanet != -1 && planets[selectedPlanet].SelectedColony != -1)
            {
                planets[selectedPlanet].colonies
                    [planets[selectedPlanet].SelectedColony].CreateBuilding<Sawmill>
                    (new ResourceBox(20, 100, formUI));
            }
        }
    }
}
