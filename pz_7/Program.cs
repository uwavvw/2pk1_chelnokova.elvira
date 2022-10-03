using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[100];
            int[] b = new int[100];
            Random r = new Random();
            for (int i = 0; i < 10; i++)
            {
                a[i] = r.Next(0, 100);
                Console.Write(a[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
