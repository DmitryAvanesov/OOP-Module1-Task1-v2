using System;

namespace OOP_Module1_Task1_v2
{
    class Goldmine : Building
    {
        public override string Name => "Goldmine";
        public Goldmine() : base() { }

        public override void GetResource(object sender, EventArgs e)
        {
            Random random = new Random();
            GetResourcesInner(new ResourceBox(random.Next(1, 5), 0, FormUI));
        }
    }
}
