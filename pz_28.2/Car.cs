using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
delegate void MyDelegate(int a);

namespace pz_28._2
{
    internal class Car
    {
        public event MyDelegate Myevent;
        public void RaiseMyEvent(int i)
        {
            if (Myevent != null)
            {
                for (i = 0; i <= 200; i++)
                {
                   Myevent?.Invoke(i);    
                }
            }

        }
    }
}
