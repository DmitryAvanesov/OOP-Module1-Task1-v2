using System;
using System.Windows.Forms;

namespace OOP_Module1_Task1_v2
{
    class Sawmill : Building
    {
        public Sawmill() : base() { }

        public override void GetResource(object sender, EventArgs e)
        {
            Random random = new Random();
            Storage.Earn<Wood>(random.Next(2, 8));
        }
    }
}
