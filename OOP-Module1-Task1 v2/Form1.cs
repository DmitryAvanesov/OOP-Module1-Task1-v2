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
                AutoSize = true
            };

            labelPosition += 20;
            planetsPanel.Controls.Add(planetLabel);
        }

        private void AddPlanetButton_Click(object sender, EventArgs e)
        {
            if (planets.Count < 45)
            {
                AddPlanet(inputPlanetName.Text);
            }
        }
    }
}
