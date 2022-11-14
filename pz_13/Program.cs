using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_13
{
    internal class Program
    {
        static void MinusTemperature(double[] week)
        {
            int count = 0;
            for (int i = 0; i < week.Length; i++)
            {
                if (week[i] < 0)
                {
                    count++;
                }
            }
            Console.WriteLine("Количество дней, в которых температура опускалась ниже нуля: " + count);
            Console.ReadKey();
        }
        static void Main(string[] args)
        {
            int length = 7;
            double[] week = new double[length];
            Console.WriteLine("Введите температуру за 7 дней:");
            for (int i = 0; i < week.Length; i++)
            {
                week[i] = Convert.ToDouble(Console.ReadLine());
            }
            for (int i = 0; i < week.Length; i++)
            {
                Console.WriteLine(week[i] + "°C");
            }
            MinusTemperature(week);
        }
    }
}
