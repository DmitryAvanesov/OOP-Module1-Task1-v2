using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Module1_Task1_v2
{
    public partial class Form1 : Form
    {
        private List<Planet> planets = new List<Planet>();
        private int labelPosition = 10;
        public string ColoniesLabel { get; }

        public Form1()
        {
            InitializeComponent();

            // fullscreen
            TopMost = true;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }

        public void AddPlanet(string name)
        {
            planets.Add(new Planet(name));

            Label planetLabel = new Label
            {
                Text = string.Format("{0} | {1} km radius | x: {2}; y: {3}",
                planets[planets.Count - 1].Name,
                planets[planets.Count - 1].Radius,
                planets[planets.Count - 1].Coordinates.X,
                planets[planets.Count - 1].Coordinates.Y),

                Location = new Point(10, labelPosition),
                AutoSize = true,
                Name = (planets.Count - 1).ToString()
            };
            planets[planets.Count - 1].label = planetLabel;

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
                    planets[currentPlanet].Unselect(coloniesPanel);
                    break;
                }
            }

            for (int currentPlanet = 0; currentPlanet < planets.Count; currentPlanet++)
            {
                if (currentPlanet == int.Parse(planetLabel.Name))
                {
                    planets[currentPlanet].Select(coloniesPanel);
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
                    planets[currentPlanet].CreateColony(inputColonyName.Text, coloniesPanel);
                }
            }
        }
    }
}
