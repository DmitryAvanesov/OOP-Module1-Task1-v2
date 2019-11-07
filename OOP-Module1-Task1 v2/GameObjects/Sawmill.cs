using System;

namespace OOP_Module1_Task1_v2
{
    class Sawmill : Building
    {
        const int MinAmount = 1;
        const int MaxAmount = 10;

        public override string Name => "Sawmill";
        public Sawmill() : base() { }

        public override void GetResource(object sender, EventArgs e)
        {
            Random random = new Random();
            GetResourcesInner(new ResourceBox(0, random.Next(MinAmount, MaxAmount), FormUI));
        }
    }
}
