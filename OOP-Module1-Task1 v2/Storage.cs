using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace OOP_Module1_Task1_v2
{
    class Storage
    {
        public Dictionary<Type, Resource> resources = new Dictionary<Type, Resource>();
        private Panel resourcesPanel;
        private int labelPosition;

        public Storage(int goldAmount, int woodAmount, Panel newResourcesPanel)
        {
            resources[typeof(Gold)] = new Gold(goldAmount);
            resources[typeof(Wood)] = new Wood(woodAmount);

            resourcesPanel = newResourcesPanel;
            ShowResources();
        }

        public T GetResource<T>()
            where T : Resource
        {
            return (T)resources[typeof(T)];
        }

        public void Pay<T>(int cost)
        {
            resources[typeof(T)].Amount -= cost;
            ShowResources();
        }

        public void Earn<T>(int sum)
        {
            resources[typeof(T)].Amount += sum;
            ShowResources();
        }

        public void ShowResources()
        {
            resourcesPanel.Controls.Clear();

            foreach (var resource in resources)
            {
                labelPosition = 850;

                Label resourcesLabel = new Label
                {
                    Text = string.Format("{0}: {1}",
                    resource.Value.Name,
                    resource.Value.Amount),

                    Location = new Point(10, labelPosition),
                    AutoSize = true,
                    Font = new Font("Arial", 14)
                };

                resourcesPanel.Controls.Add(resourcesLabel);
                labelPosition += 30;
            }
        }
    }
}
