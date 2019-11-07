using System;

namespace OOP_Module1_Task1_v2
{
    class Wood : Resource
    {
        public override string Name => "Wood";

        public Wood(int newAmount) : base(newAmount) { }
    }
}
