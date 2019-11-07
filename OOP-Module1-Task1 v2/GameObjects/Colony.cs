using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OOP_Module1_Task1_v2
{
    class Colony : ISelectableObject
    {
        public string Name { get; }
        public int Number { get; }
        public bool IsSelected { get; set; }
        public Planet Planet { get; }

        private readonly UserInterface formUI;
        private readonly IList<Building> _buildings;

        public Colony(string colonyName, int colonyNumber,
            UserInterface thisUI, Planet thisPlanet)
        {
            IsSelected = false;
            Name = colonyName;
            Number = colonyNumber;
            formUI = thisUI;
            Planet = thisPlanet;
            _buildings = new List<Building>();
        }

        public void Unselect()
        {
            IsSelected = false;
            formUI.OnUnselectColony(Number);
        }

        public void Select()
        {
            IsSelected = true;
            formUI.OnSelectColony(Number);
            formUI.ShowBuildings(_buildings);
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
                    FormUI = formUI
                };

                _buildings.Add(newBuilding);
                Planet.Storage.Pay(value);
                formUI.OnCreateBuilding(newBuilding);
            }
        }
    }
}
