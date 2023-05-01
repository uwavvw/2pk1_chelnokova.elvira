using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_28
{
    internal class Wait
    {
        public int chislo;
        public Wait(int count) { chislo = count; }
        public void show (int chislo ) 
        {  
             Console.WriteLine($"\nПоявилось число: {chislo}");
        }
    }
}
