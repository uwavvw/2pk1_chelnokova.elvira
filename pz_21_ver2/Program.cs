using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_21_ver2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ID студента (0 - 1): ");
            Account acc = new Account();
            acc.PrintInfo();
            Console.ReadKey();
        }
    }
}
