using System;
using System.Windows.Forms;

namespace OOP_Module1_Task1_v2
{
    class Goldmine : Building
    {
        public Goldmine()
        {
            Random random = new Random();
            coordinates = new Coordinates(random.Next(-100, 100), random.Next(-100, 100));

            timer = new Timer();
            timer.Tick += new EventHandler(GetGold);
            timer.Interval = interval;
            timer.Start();
        }

        public void GetGold(object sender, EventArgs e)
        {
            
        }
    }
}
