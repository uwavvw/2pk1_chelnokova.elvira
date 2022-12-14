using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_17
{
    internal class Program
    {
        unsafe
        static void Main(string[] args)
        {
            
            int a;
            
            char** b;
            char* c = (char*)&a;
            b = &c;
            **b = '+';
            *(*b + 1) = '*';
            Console.WriteLine($"содержимое переменной а { a}");
            Console.WriteLine($"значение типа char {**b}");
            Console.WriteLine($"значение типа char {*(*b+1)}");
            Console.WriteLine("");
            Console.ReadLine();
        }
    }
}
