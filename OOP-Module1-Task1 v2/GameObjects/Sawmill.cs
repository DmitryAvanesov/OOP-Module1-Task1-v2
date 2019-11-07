using System;

namespace OOP_Module1_Task1_v2
{
    class Sawmill : Building
    {
        public override string Name => "Sawmill";
        public Sawmill() : base() { }

        public override void GetResource(object sender, EventArgs e)
        {
            Random random = new Random();
            GetResourcesInner(new ResourceBox(0, random.Next(1, 10), FormUI));
        }
    }
}
