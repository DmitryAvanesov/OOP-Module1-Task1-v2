using System;
using System.Windows.Forms;

namespace OOP_Module1_Task1_v2
{
    abstract class Building : MapObject
    {
        public abstract string Name { get; }
        public Storage Storage { get; set; }
        public Planet Planet { get; set; }

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

        protected void GetResourcesInner<T>(int gold, int wood)
        {
            Random random = new Random();
            int resourceAmount = random.Next(gold, wood);

            if (resourceAmount <= Planet.planetResources[typeof(T)].Amount)
            {
                Storage.Earn<T>(resourceAmount);
                Planet.ExtractResources<T>(resourceAmount);

                if (Planet.IsSelected)
                {
                    Storage.ShowResources();
                    Planet.ShowPlanetResources();
                }
            }
        }
    }
}
