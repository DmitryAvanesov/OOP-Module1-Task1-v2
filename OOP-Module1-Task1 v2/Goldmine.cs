using System;
using System.Windows.Forms;

namespace OOP_Module1_Task1_v2
{
    class Goldmine : Building
    {
        private Gold goldIngot;

        public Goldmine(string buildingName, Budget budget)
        {
            name = buildingName;
            Random random = new Random();
            coordinates = new Coordinates(random.Next(-100, 100), random.Next(-100, 100));
            mainBudget = budget;

            timer = new Timer();
            timer.Tick += new EventHandler(GetGold);
            timer.Interval = interval;
            timer.Start();
        }

        public void GetGold(object sender, EventArgs e)
        {
            goldIngot = new Gold();
            mainBudget.IncreaseBudget(goldIngot);
        }
    }
}
