using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_14
{
    internal class Program
    {

        /*1 задание
        private static double a = -30;
        static void rec(double n, double i)
        {
            
            if (i < n)
            {
                double shag = 0.4;
                i++;
                a += shag;
                rec(n, i);
            }
            else if (i == n)
            {
                Console.WriteLine(a);
            }

        }
        static void Main(string[] args)
        {
            int i = 0;
            Console.WriteLine("Введите n-ый член прогрессии");
            double n1 = double.Parse(Console.ReadLine());
            rec(n1, i);
            Console.ReadKey();   
        }*/
        //2 задание
        private static double a = 7;
        static void rec2(double n, double i)
        {
            if (i < n)
            {
                double shag = 0.5;
                i++;
                
                a *= (Math.Pow(shag, n - 1)); 
                rec2(n, i);
            }
            else if (i == n)
            {
                Console.WriteLine(a);
            }
        }
        static void Main(string[] args)
        {
            int i = 0;
            Console.WriteLine("Введите n-ый член прогрессии");
            double n1 = double.Parse(Console.ReadLine());
            rec2(n1,i);
            Console.ReadKey();
        }
        //3 задание
        //static void rec3 ( double a )
    }
}
