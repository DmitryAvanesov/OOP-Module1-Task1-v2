using System;

namespace OOP_Module1_Task1_v2
{
    class Goldmine : Building
    {
        const int MinAmount = 1;
        const int MaxAmount = 5;

        public override string Name => "Goldmine";
        public Goldmine() : base() { }

        public override void GetResource(object sender, EventArgs e)
        {
            Random random = new Random();
            GetResourcesInner(new ResourceBox(random.Next(MinAmount, MaxAmount), 0, FormUI));
        }
    }
}
