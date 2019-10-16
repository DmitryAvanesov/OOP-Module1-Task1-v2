using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace OOP_Module1_Task1_v2
{
    class Storage
    {
        public Panel ResourcesPanel { get; }

        public Dictionary<Type, Resource> resources = new Dictionary<Type, Resource>();
        private int labelPosition;

        public Storage(int goldAmount, int woodAmount, Panel newResourcesPanel)
        {
            resources[typeof(Gold)] = new Gold(goldAmount);
            resources[typeof(Wood)] = new Wood(woodAmount);

            ResourcesPanel = newResourcesPanel;
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
        }

        public void ShowResources()
        {
            ResourcesPanel.Controls.Clear();
            labelPosition = 10;

            foreach (var resource in resources)
            {
                Label resourcesLabel = new Label
                {
                    Text = string.Format("{0}: {1}",
                    resource.Value.Name,
                    resource.Value.Amount),

                    Location = new Point(10, labelPosition),
                    AutoSize = true,
                    Font = new Font("Arial", 14)
                };

                ResourcesPanel.Controls.Add(resourcesLabel);
                labelPosition += 30;
            }
        }
    }
}
