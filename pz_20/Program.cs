using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите слово:");
            string text = Console.ReadLine();
            char[] myArray = text.ToCharArray();
            for (int i = 0; i < myArray.Length; i++)
            {
                if (myArray[i] >= 'А' && myArray[i] <= 'Я' || myArray[i] >= 'A' && myArray[i] <= 'Z')
                {
                    Console.Write(Char.ToLower(myArray[i]) + "");
                }
                else if (myArray[i] >= 'а' && myArray[i] <= 'я' || myArray[i] >= 'a' && myArray[i] <= 'z')
                {
                    Console.Write(Char.ToUpper(myArray[i]) + "");
                }
                else
                {
                    Console.WriteLine("Введен неправильный символ");
                }
            }
            Console.ReadLine();
        }
    }
}
