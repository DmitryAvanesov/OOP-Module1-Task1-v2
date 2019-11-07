using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace OOP_Module1_Task1_v2
{
    class Planet : MapObject, ISelectableObject
    {
        public bool IsSelected { get; set; }
        public string Name { get; }
        public int Number { get; }
        public int Radius { get; }
        public int SelectedColony { get; private set; }
        public ResourceBox Storage { get; }
        public Form1 Form { get; }

        private UserInterface formUI;
        public IList<Colony> colonies;
        public Dictionary<Type, Resource> planetResources;

        public Planet(string newName, UserInterface thisUI, int thisNumber, Form1 thisForm)
        {
            IsSelected = false;
            Name = newName;
            formUI = thisUI;
            Number = thisNumber;
            Form = thisForm;
            SelectedColony = -1;
            colonies = new List<Colony>();
            planetResources = new Dictionary<Type, Resource>();

            Random random = new Random();
            coordinates = new Coordinates(random.Next(-10000, 10000), random.Next(-10000, 10000));
            Radius = random.Next(100, 1000);

            planetResources[typeof(Gold)] = new Gold(Radius +
                random.Next(-Radius / 3, Radius / 3));
            planetResources[typeof(Wood)] = new Wood(Radius +
                random.Next(-Radius / 2, Radius / 2));

            Storage = new ResourceBox(100, 200, formUI);
        }

        public void Unselect()
        {
            IsSelected = false;

            if (SelectedColony != -1)
            {
                colonies[SelectedColony].Unselect();
                SelectedColony = -1;
            }

            formUI.OnUnselectPlanet(Number);
        }

        public void Select()
        {
            IsSelected = true;
            formUI.OnSelectPlanet(Number);

            formUI.ShowColonies(colonies);
            formUI.ShowResources(Storage.resources);
            formUI.ShowPlanetResources(planetResources);
        }

        public void CreateColony(string colonyName)
        {
            Colony newColony = new Colony(colonyName, colonies.Count, formUI, this);
            formUI.OnCreateColony(newColony);
            colonies.Add(newColony);
        }

        public void SelectColony(object sender)
        {
            Label colonyLabel = sender as Label;

            if (SelectedColony != -1)
            {
                colonies[SelectedColony].Unselect();
            }
            SelectedColony = int.Parse(colonyLabel.Name);
            colonies[SelectedColony].Select();
        }

        public void ExtractResources(ResourceBox value)
        {
            foreach (KeyValuePair<Type, Resource> currentResource in value.resources)
            {
                planetResources[currentResource.Key].Amount -= currentResource.Value.Amount;
            }
        }
    }
}
