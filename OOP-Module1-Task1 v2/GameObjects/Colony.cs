using System;
using System.Collections.Generic;

namespace OOP_Module1_Task1_v2
{
    class Colony : ISelectableObject
    {
        public string Name { get; }
        public int Number { get; }
        public bool IsSelected { get; set; }
        public Planet Planet { get; }

        private readonly UserInterface _formUI;
        private readonly IList<Building> _buildings;

        public Colony(string colonyName, int colonyNumber,
            UserInterface thisUI, Planet thisPlanet)
        {
            IsSelected = false;
            Name = colonyName;
            Number = colonyNumber;
            _formUI = thisUI;
            Planet = thisPlanet;
            _buildings = new List<Building>();
        }

        public void Unselect()
        {
            IsSelected = false;
            _formUI.OnUnselectColony(Number);
        }

        public void Select()
        {
            IsSelected = true;
            _formUI.OnSelectColony(Number);
            _formUI.ShowBuildings(_buildings);
        }

        public void CreateBuilding<T>(ResourceBox value)
            where T : Building, new()
        {
            bool enoughMoney = true;

            foreach (KeyValuePair<Type, Resource> currentResource in value.resources)
            {
                if (currentResource.Value.Amount >
                    Planet.Storage.resources[currentResource.Key].Amount)
                {
                    enoughMoney = false;
                }
            }

            if (enoughMoney)
            {
                T newBuilding = new T
                {
                    Planet = Planet,
                    Number = _buildings.Count,
                    FormUI = _formUI
                };

                _buildings.Add(newBuilding);
                Planet.Storage.Pay(value);
                _formUI.OnCreateBuilding(newBuilding);
            }
        }
    }
}
