using System;
using System.Windows.Forms;

namespace OOP_Module1_Task1_v2
{
    class Sawmill : Building
    {
        private Wood woodPlank;

        public Sawmill(string buildingName, Budget budget)
        {
            name = buildingName;
            Random random = new Random();
            coordinates = new Coordinates(random.Next(-100, 100), random.Next(-100, 100));
            mainBudget = budget;

            timer = new Timer();
            timer.Tick += new EventHandler(GetWood);
            timer.Interval = interval;
            timer.Start();
        }

        public void GetWood(object sender, EventArgs e)
        {
            woodPlank = new Wood();
            mainBudget.IncreaseBudget(woodPlank);
        }
    }
}
