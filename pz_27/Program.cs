using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ZNAK[] BOOK = new ZNAK[8];
            int[] bday = new int[3];
            Console.WriteLine("Введите количество структур");
            int value = int.Parse(Console.ReadLine());
            for (int i = 1; i < 8; i++)
            {
                Console.WriteLine($"{i}) Введите Имя:"); 
                string name = Console.ReadLine();
                Console.WriteLine(" Введите Знак Зодиака:");
                string znakzod = Console.ReadLine();
                Console.WriteLine(" Введите число рождения:");
                int dd = int.Parse(Console.ReadLine());
                Console.WriteLine(" Введите месяц Рождения:");
                int mm = int.Parse(Console.ReadLine());
                Console.WriteLine(" Введите год Рождения:");
                int gg = int.Parse(Console.ReadLine());
               
            }
            //for (int i = 0; i < 8; i++)
            //{
            //    Console.WriteLine("Введите Имя:");
            //    string name = Console.ReadLine();
            //    Console.WriteLine("Введите Знак Зодиака:");
            //    string zodiak = Console.ReadLine();
            //    //Console.WriteLine("Введите число рождения:");
            //    //int dd = int.Parse(Console.ReadLine()); 
            //    //Console.WriteLine("Введите месяц Рождения:");
            //    //int mm = int.Parse(Console.ReadLine());
            //    //Console.WriteLine("Введите год Рождения:");
            //    //int gg = int.Parse(Console.ReadLine());
            //    Console.WriteLine("Введите дату рождения:");
            //    string[] bd = Console.ReadLine().Split(); 
            //    int[] bday = new int[3];
            //    for (int j = 0; j < 3; j++)
            //    {
            //        bday[j] = int.Parse(bd[j]);
            //    }
            //   

            //}
            ZNAK men1 = new ZNAK ("Иван Иванов", "Весы", new int[] { 12, 10, 1999 } );
            ZNAK men2 = new ZNAK("Роман Романов", "Овен", new int[] { 19, 04, 2001 });
            ZNAK men3 = new ZNAK("Софья Алексеевна", "Дева", new int[] { 02, 09, 1989 });
            ZNAK men4 = new ZNAK("Александр Сидоров", "Рак", new int[] { 17, 07, 2005 });

            Console.WriteLine("Введите Знак Зодиака:");
            string zodiak = Console.ReadLine();
            if (zodiak == "весы" || zodiak == "Весы")
            {
                men1.PrintInfo();
            }
            else if (zodiak == "овен" || zodiak == "Овен")
            {
                men2.PrintInfo();
            }
            else if (zodiak == "дева" || zodiak == "Дева")
            {
                men3.PrintInfo();
            }
            else if (zodiak == "рак" || zodiak == "Рак")
            {
                men4.PrintInfo();
            }
            else
                Console.WriteLine("Данных не существует");
            Console.ReadKey();
        }
    }
    struct ZNAK
    {
       public string NAME;
       public string ZODIAC;
       public int[] BDAY;

        public ZNAK(string name, string zodiak, int[] bday)
        {
            NAME = name;
            ZODIAC = zodiak;
            BDAY = new int[bday.Length];
            BDAY = bday;
        }
        public void PrintInfo()
        {
            Console.WriteLine($"Имя и Фамилия: {NAME}\nЗнак Зодиака: {ZODIAC}\nДень рождение: {BDAY[0]}.{BDAY[1]}.{BDAY[2]}");
        }

    }
}
