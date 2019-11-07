using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OOP_Module1_Task1_v2
{
    abstract class Building : MapObject
    {
        public abstract string Name { get; }
        public int Number { get; set; }
        public Planet Planet { get; set; }

        public UserInterface FormUI;
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

        protected void GetResourcesInner(ResourceBox extraction)
        {
            bool enoughResources = true;

            foreach (KeyValuePair<Type, Resource> currentResource in extraction.resources)
            {
                if (currentResource.Value.Amount >
                    Planet.planetResources[currentResource.Key].Amount)
                {
                    enoughResources = false;
                }
            }

            if (enoughResources)
            {
                Planet.Storage.Earn(extraction);
                Planet.ExtractResources(extraction);

                if (Planet.IsSelected)
                {
                    FormUI.ShowResources(Planet.Storage.resources);
                    FormUI.ShowPlanetResources(Planet.planetResources);
                }
            }
        }
    }
}
