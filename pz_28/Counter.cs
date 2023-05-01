using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
delegate void MyDelegate(int a);

namespace pz_28
{
    internal class Counter
    {
        public event MyDelegate Myevent;
       
        public void RaiseMyEvent(int i)
        {
            if (Myevent != null)
            {
                for ( i = 0; i < 1001; i++) 
                {
                    
                    if (i == 200)
                    {
                        Myevent?.Invoke(i);
                    }
                    else if (i == 800)
                    {
                        Myevent?.Invoke(i);
                    }
                    //Console.Write($"{i}, ") ;
                }
            }

        }
    }

}
