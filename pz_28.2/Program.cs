using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace pz_28._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car obj = new Car();
            Patrul wait200 = new Patrul(1);
           
            obj.RaiseMyEvent(1);
            obj.Myevent += wait200.show;
            obj.RaiseMyEvent(1);
            
            Console.ReadKey();
        }
    }
}
