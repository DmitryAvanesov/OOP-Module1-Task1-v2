using System;
using System.Windows.Forms;

namespace OOP_Module1_Task1_v2
{
    abstract class Building : MapObject
    {
        public Storage Storage { get; set; }

        protected Timer timer;
        protected int interval = 5000;

        public Building()
        {
            Random random = new Random();
            coordinates = new Coordinates(random.Next(-100, 100), random.Next(-100, 100));

            timer = new Timer();
            timer.Tick += new EventHandler(GetResource);
            timer.Interval = interval;
            timer.Start();
        }

        public abstract void GetResource(object sender, EventArgs e);
    }
}
