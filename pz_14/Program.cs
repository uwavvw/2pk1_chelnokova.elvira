using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_14
{
    internal class Program
    {
        static void Main(string[] args)
        
       {
            Console.WriteLine("Введите n:");
            double n = double.Parse(Console.ReadLine());
            double a1 = -30;
            double b1 = 7;
            Console.WriteLine("Задача 1");
            Console.WriteLine(ArithmeticProgression(a1, n));
            Console.WriteLine("Задача 2");
            Console.WriteLine(Geometricprogression(b1, n));
            Console.WriteLine("Задача 3");
            Console.WriteLine(AllNumbers(58, -26));
            Console.ReadKey();
        }
        static double ArithmeticProgression(double a1, double n)
        {
            double d = 0.4;
            if (n == 1)
            {
                return a1;
            }
            else
            {
                double result = ArithmeticProgression(a1 + d, --n);
                return result;
            }
            
        }
        static double Geometricprogression(double b1, double n)
        {
            double q = 5;
            if (n == 1)
            {
                return b1;

            }
            else
            {
                double result = Geometricprogression(b1 * q, --n);
                return result;
            }

        }
        static string AllNumbers(double A, double B)
        {
            if (A == B)
            {
                return Convert.ToString(A);
            }
            else if (A > B)
            {
                return A + " " + AllNumbers(A - 1, B);
            }
            else
            {
                return A + " " + AllNumbers(A + 1, B);
            }
        }
        
    }
}
