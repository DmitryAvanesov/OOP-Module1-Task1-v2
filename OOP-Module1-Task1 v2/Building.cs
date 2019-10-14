using System.Windows.Forms;

namespace OOP_Module1_Task1_v2
{
    abstract class Building : MapObject
    {
        protected Timer timer;
        protected int interval = 5000;
    }
}
