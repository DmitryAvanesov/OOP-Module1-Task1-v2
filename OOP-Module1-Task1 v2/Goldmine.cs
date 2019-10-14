using System;
using System.Windows.Forms;

namespace OOP_Module1_Task1_v2
{
    class Goldmine : Building
    {
        public Goldmine() : base() { }

        public override void GetResource(object sender, EventArgs e)
        {
            Random random = new Random();
            Storage.Earn<Gold>(random.Next(1, 3));
        }
    }
}
