using System;

namespace OOP_Module1_Task1_v2
{
    class Sawmill : Building
    {
        public override string Name => "Sawmill";
        public Sawmill() : base() { }

        public override void GetResource(object sender, EventArgs e)
        {
            GetResourcesInner<Wood>(1, 7);
        }
    }
}
