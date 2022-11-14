using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_12
{
    internal class Program
    {
        static void GetMinMax(double x, double y, out double z )
        {

            if (x > y)
            {
                z = x;
            }
            else if (x < y)
            {
                z = y;
            }
            else
                z = x;
            
            Console.WriteLine(z);
        }
        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double z;
            GetMinMax(a, b, out z);
            double max1 = Math.Max(a, b);
            double d = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            double z1;
            GetMinMax(d, c, out z1);
            double max2 = Math.Max(d, c);
            double z2;
            GetMinMax(max1, max2, out z2);
            double max3 = Math.Max(max1, max2);
            
            
            Console.ReadLine();

        }
    }
}
