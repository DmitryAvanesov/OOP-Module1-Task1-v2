using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_Module1_Task1_v2
{
    interface SelectableObject
    {
        void Select(Panel coloniesPanel);
        void Unselect(Panel coloniesPanel);
    }
}
