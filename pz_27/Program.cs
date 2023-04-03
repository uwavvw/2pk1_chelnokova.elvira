using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_27
{
    internal class Program
    {
        struct ZNAK
        {
            public string NAME;
            public string ZODIAC;
            public int[] BDAY;


        }
        
        
            static void Main(string[] args)
            {
                ZNAK[] BOOK = new ZNAK[8];
                for (int i = 0; i < 8; i++)
                {
                    Console.WriteLine("Введите Имя:");
                    BOOK[i].NAME = Console.ReadLine();
                    Console.WriteLine("Введите Знак Зодиака:");
                    BOOK[i].ZODIAC = Console.ReadLine();
                    Console.WriteLine("Введите День рождение, нажимая Enter после каждого введенного числа:");
                    BOOK[i].BDAY = new int[3];
                    for (int j = 0; j < 3; j++)
                    {
                        BOOK[i].BDAY[j] = int.Parse(Console.ReadLine());
                    }
                }
                Array.Sort(BOOK, (a, b) =>
                {
                    int fdsf = a.BDAY[2].CompareTo(b.BDAY[2]);
                    if (fdsf == 0)
                    {
                        fdsf = a.BDAY[1].CompareTo(b.BDAY[1]);
                        if (fdsf == 0)
                        {
                            fdsf = a.BDAY[0].CompareTo(b.BDAY[0]);
                        }
                    }
                    return fdsf;
                });
                Console.WriteLine("Введите знак зодиака человека, которого вы хотите узнать:");
                string zodiak = Console.ReadLine();
                Console.WriteLine($"Люди под знаком зодиака: {zodiak}");
                foreach (ZNAK person in BOOK)
                {
                    if (person.ZODIAC == zodiak)
                    {
                        Console.WriteLine($"Имя и Фамилия: {person.NAME}\nЗнак Зодиака: {person.ZODIAC}\nДень рождение: {person.BDAY[0]}.{person.BDAY[1]}.{person.BDAY[2]}");
                    }
                    else if (person.ZODIAC != zodiak)
                    {
                        Console.WriteLine("Данные не найдены");
                    }
                }
                Console.ReadKey();
            }
        
    }
}
