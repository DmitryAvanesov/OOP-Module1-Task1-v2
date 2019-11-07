using System;
using System.Collections.Generic;

namespace OOP_Module1_Task1_v2
{
    class ResourceBox
    {
        private readonly UserInterface _formUI;
        public Dictionary<Type, Resource> resources;

        public ResourceBox(int goldAmount, int woodAmount, UserInterface thisUI)
        {
            resources = new Dictionary<Type, Resource>
            {
                [typeof(Gold)] = new Gold(goldAmount),
                [typeof(Wood)] = new Wood(woodAmount)
            };

            _formUI = thisUI;
        }

        public T GetResource<T>()
            where T : Resource
        {
            return (T)resources[typeof(T)];
        }

        public void Pay(ResourceBox value)
        {
            foreach (KeyValuePair<Type, Resource> currentResource in value.resources)
            {
                resources[currentResource.Key].Amount -= currentResource.Value.Amount;
            }

            _formUI.ShowResources(resources);
        }

        public void Earn(ResourceBox value)
        {
            foreach (KeyValuePair<Type, Resource> currentResource in value.resources)
            {
                resources[currentResource.Key].Amount += currentResource.Value.Amount;
            }
        }
    }
}
