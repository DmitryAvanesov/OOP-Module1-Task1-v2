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
        private Budget budget;

        public Form1()
        {
            InitializeComponent();

            // fullscreen
            TopMost = true;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;

            labelPosition = 10;
            budget = new Budget(goldLabel, woodLabel);
        }

        public void AddPlanet(string name)
        {
            planets.Add(new Planet(name));

            Label planetLabel = new Label
            {
                Text = string.Format("{0} | {1} km radius | x: {2}; y: {3}",
                planets[planets.Count - 1].Name,
                planets[planets.Count - 1].Radius,
                planets[planets.Count - 1].coordinates.X,
                planets[planets.Count - 1].coordinates.Y),

                Location = new Point(10, labelPosition),
                AutoSize = true,
                Name = (planets.Count - 1).ToString()
            };

            planets[planets.Count - 1].Label = planetLabel;
            planets[planets.Count - 1].ColoniesPanel = coloniesPanel;
            planets[planets.Count - 1].BuildingsPanel = buildingsPanel;

            planetLabel.Click += new EventHandler(SelectPlanet);

            labelPosition += 20;
            planetsPanel.Controls.Add(planetLabel);
        }

        private void SelectPlanet(object sender, EventArgs e)
        {
            Label planetLabel = sender as Label;

            for (int currentPlanet = 0; currentPlanet < planets.Count; currentPlanet++)
            {
                if (planets[currentPlanet].IsSelected)
                {
                    planets[currentPlanet].Unselect();
                    break;
                }
            }

            for (int currentPlanet = 0; currentPlanet < planets.Count; currentPlanet++)
            {
                if (currentPlanet == int.Parse(planetLabel.Name))
                {
                    planets[currentPlanet].Select();
                    break;
                }
            }
        }

        private void AddPlanetButton_Click(object sender, EventArgs e)
        {
             AddPlanet(inputPlanetName.Text);
        }

        private void AddColonyButton_Click(object sender, EventArgs e)
        {
            for (int currentPlanet = 0; currentPlanet < planets.Count; currentPlanet++)
            {
                if (planets[currentPlanet].IsSelected)
                {
                    planets[currentPlanet].CreateColony(inputColonyName.Text);
                    break;
                }
            }
        }

        private void AddGoldmineButton_Click(object sender, EventArgs e)
        {
            for (int currentPlanet = 0; currentPlanet < planets.Count; currentPlanet++)
            {
                if (planets[currentPlanet].IsSelected)
                {
                    for (int currentColony = 0; currentColony < planets.Count; currentColony++)
                    {
                        if (planets[currentPlanet].colonies[currentColony].IsSelected)
                        {
                            planets[currentPlanet].colonies[currentColony].CreateGoldmine(
                                inputBuildingName.Text, budget);
                            break;
                        }
                    }
                }
            }
        }

        private void AddSawmillButton_Click(object sender, EventArgs e)
        {
            for (int currentPlanet = 0; currentPlanet < planets.Count; currentPlanet++)
            {
                if (planets[currentPlanet].IsSelected)
                {
                    for (int currentColony = 0; currentColony < planets.Count; currentColony++)
                    {
                        if (planets[currentPlanet].colonies[currentColony].IsSelected)
                        {
                            planets[currentPlanet].colonies[currentColony].CreateSawmill(
                                inputBuildingName.Text, budget);
                            break;
                        }
                    }
                }
            }
        }
    }
}
