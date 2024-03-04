using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace MidProjectEven.Classes.DL
{
    public  class StoreControls
    {
        public static Stack<UserControl> controlStack = new Stack<UserControl>();

        public static void AddControl(UserControl control)
        {
            controlStack.Push(control); 
        }
        public static void DeleteControl()
        {
            if (controlStack.Count > 0) {
                controlStack.Pop();
            }
         
        }

    }
}
