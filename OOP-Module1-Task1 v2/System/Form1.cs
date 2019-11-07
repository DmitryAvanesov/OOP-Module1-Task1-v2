using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace OOP_Module1_Task1_v2
{
    public partial class Form1 : Form
    {
        const int CostGoldmineGold = 100;
        const int CostGoldmineWood = 75;
        const int CostSawmillGold = 50;
        const int CostSawmillWood = 125;

        private readonly UserInterface _formUI;
        private readonly IList<Planet> _planets;
        private int _selectedPlanet;

        public Form1()
        {
            InitializeComponent();

            _formUI = new UserInterface(planetsPanel, coloniesPanel,
                buildingsPanel, planetResourcesPanel, resourcesPanel);
            _planets = new List<Planet>();
            _selectedPlanet = -1;
        }

        public void AddPlanet(string name)
        {
            Planet newPlanet = new Planet(name, _formUI, _planets.Count, this);
            _formUI.OnAddPlanet(newPlanet);
            _planets.Add(newPlanet);
        }

        public void SelectPlanet(object sender)
        {
            Label planetLabel = sender as Label;

            if (_selectedPlanet != -1)
            {
                _planets[_selectedPlanet].Unselect();
            }
            _selectedPlanet = int.Parse(planetLabel.Name);
            _planets[_selectedPlanet].Select();
        }

        private void AddPlanetButton_Click(object sender, EventArgs e)
        {
             AddPlanet(inputPlanetName.Text);
        }

        private void AddColonyButton_Click(object sender, EventArgs e)
        {
            if (_selectedPlanet != -1)
            {
                _planets[_selectedPlanet].CreateColony(inputColonyName.Text);
            }
        }

        private void AddGoldmineButton_Click(object sender, EventArgs e)
        {
            if (_selectedPlanet != -1 && _planets[_selectedPlanet].SelectedColony != -1)
            {
                _planets[_selectedPlanet].colonies
                    [_planets[_selectedPlanet].SelectedColony].CreateBuilding<Goldmine>
                    (new ResourceBox(CostGoldmineGold, CostGoldmineWood, _formUI));
            }
        }

        private void AddSawmillButton_Click(object sender, EventArgs e)
        {
            if (_selectedPlanet != -1 && _planets[_selectedPlanet].SelectedColony != -1)
            {
                _planets[_selectedPlanet].colonies
                    [_planets[_selectedPlanet].SelectedColony].CreateBuilding<Sawmill>
                    (new ResourceBox(CostSawmillGold, CostSawmillWood, _formUI));
            }
        }
    }
}
