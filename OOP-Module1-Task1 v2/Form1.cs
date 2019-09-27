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

        public Form1()
        {
            InitializeComponent();

            // fullscreen
            TopMost = true;
            FormBorderStyle = FormBorderStyle.None;
            WindowState = FormWindowState.Maximized;
        }

        public void AddPlanet(string name, int xCoord, int yCoord)
        {
            planets.Add(new Planet(name, new Coordinates(xCoord, yCoord)));

            Label planetLabel = new Label
            {
                Text = planets[planets.Count - 1].Name,
                Location = new Point(50, 50),
            };

            Controls.Add(planetLabel);
        }

        private void AddPlanetButton_Click(object sender, EventArgs e)
        {
            AddPlanet(inputPlanetName.Text,
                int.Parse(inputPlanetCoordinateX.Text), int.Parse(inputPlanetCoordinateY.Text));
        }
    }
}
