using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace pz_22
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ID студента ( 1 - 3 ) ");
            
            Account acc = new Account();
            acc.PrintInfo();
            
            Console.ReadKey();
        }
    }
}
    