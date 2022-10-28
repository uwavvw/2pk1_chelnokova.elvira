using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите строку");
            string str = Console.ReadLine();
            int one = 0;
            int two = 0;
            int three = 0;

            if (str.Length >= 6)
                for (int i = 0; i < str.Length; i++)
                {
                    if (char.IsUpper(str[i]))
                    {
                        one++;

                    }
                    if (char.IsLower(str[i]))
                    {
                        two++;
                    }
                    if (str.Contains('.') || str.Contains('!') || str.Contains('_') || str.Contains('-'))
                    {
                        three++;
                    }
                    else
                    {
                        Console.WriteLine("пароль не соответствует");
                    }
                }
            if (one>0 && two > 0 && three>0)
            {
                Console.WriteLine("пароль соответсвует");
            }
                
            
            Console.ReadLine();
        }
    }
}
