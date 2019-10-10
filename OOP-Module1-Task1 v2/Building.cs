using System.Windows.Forms;

namespace OOP_Module1_Task1_v2
{
    abstract class Building : MapObject
    {
        public string name;
        protected Timer timer;
        protected Budget mainBudget;
        protected int interval = 10000;
    }
}
