using System;

namespace OOP_Module1_Task1_v2
{
    class Gold : Resource
    {
        public override string Name => "Gold";

        public Gold(int newAmount) : base(newAmount) { }
    }
}
