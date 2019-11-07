using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace OOP_Module1_Task1_v2
{
    class Planet : MapObject, ISelectableObject
    {
        const int CoordinatesLimit = 10000;
        const int MinRadius = 1000;
        const int MaxRadius = 1000000;
        const int InitialGold = 750;
        const int InitialWood = 1000;
        const int MinGoldCoef = 10;
        const int MaxGoldCoef = 1000;
        const int MinWoodCoef = 50;
        const int MaxWoodCoef = 500;

        public bool IsSelected { get; set; }
        public string Name { get; }
        public int Number { get; }
        public int Radius { get; }
        public int SelectedColony { get; private set; }
        public ResourceBox Storage { get; }
        public Form1 Form { get; }

        private readonly UserInterface _formUI;
        public IList<Colony> colonies;
        public ResourceBox planetResources;
        private readonly ResourceBox _colonyCost;

        public Planet(string newName, UserInterface thisUI, int thisNumber, Form1 thisForm)
        {
            IsSelected = false;
            Name = newName;
            _formUI = thisUI;
            Number = thisNumber;
            Form = thisForm;
            SelectedColony = -1;
            colonies = new List<Colony>();

            Random random = new Random();
            Radius = random.Next(MinRadius, MaxRadius);

            planetResources = new ResourceBox(
                Radius / random.Next(MinGoldCoef, MaxGoldCoef),
                Radius / random.Next(MinWoodCoef, MaxWoodCoef),
                _formUI);

            coordinates = new Coordinates(
                random.Next(-CoordinatesLimit, CoordinatesLimit),
                random.Next(-CoordinatesLimit, CoordinatesLimit));

            _colonyCost = new ResourceBox(500, 500, _formUI);
            Storage = new ResourceBox(InitialGold, InitialWood, _formUI);
        }

        public void Unselect()
        {
            IsSelected = false;

            if (SelectedColony != -1)
            {
                colonies[SelectedColony].Unselect();
                SelectedColony = -1;
            }

            _formUI.OnUnselectPlanet(Number);
        }

        public void Select()
        {
            IsSelected = true;
            _formUI.OnSelectPlanet(Number);

            _formUI.ShowColonies(colonies);
            _formUI.ShowResources(Storage.resources);
            _formUI.ShowPlanetResources(planetResources.resources);
        }

        public void CreateColony(string colonyName)
        {
            bool enoughMoney = true;

            foreach (KeyValuePair<Type, Resource> currentResource in _colonyCost.resources)
            {
                if (currentResource.Value.Amount >
                    Storage.resources[currentResource.Key].Amount)
                {
                    enoughMoney = false;
                }
            }

            if (enoughMoney) {
                Colony newColony = new Colony(colonyName, colonies.Count, _formUI, this);
                _formUI.OnCreateColony(newColony);
                colonies.Add(newColony);

                Storage.Pay(_colonyCost);
            }
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
                planetResources.resources[currentResource.Key].Amount -=
                    currentResource.Value.Amount;
            }
        }
    }
}
