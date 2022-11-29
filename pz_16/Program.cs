using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace pz_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите S: ");
            string a = Console.ReadLine();
            if (a == "S")
            {
                using (StreamReader r = new StreamReader("text1.txt"))
                {
                    while (!r.EndOfStream)
                    {
                        string b = r.ReadLine();
                        if (b.Contains(a))
                        {
                            Console.WriteLine(b);
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("введена не та буква");
            }
            Console.ReadLine();
        }
    }
}
