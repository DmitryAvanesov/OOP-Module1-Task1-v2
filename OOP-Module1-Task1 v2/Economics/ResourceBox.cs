using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace OOP_Module1_Task1_v2
{
    class ResourceBox
    {
        public Panel ResourcesPanel { get; }

        private readonly UserInterface formUI;
        public Dictionary<Type, Resource> resources = new Dictionary<Type, Resource>();

        public ResourceBox(int goldAmount, int woodAmount, UserInterface thisUI)
        {
            resources[typeof(Gold)] = new Gold(goldAmount);
            resources[typeof(Wood)] = new Wood(woodAmount);

            formUI = thisUI;
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

            formUI.ShowResources(resources);
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
