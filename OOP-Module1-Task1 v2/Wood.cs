using System;

namespace OOP_Module1_Task1_v2
{
    class Wood : Resource
    {
        public override string Name => "Wood";

        public Wood()
        {
            Random random = new Random();
            Amount = random.Next(2, 10);
        }
    }
}
