using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int stolb = 5; // столбцов
            int str = 5;  // строк
            int[,] a = new int[str, stolb];
            for (int i = 0; i < str; i++)
                for (int j = 0; j < stolb; j++)
                    // заполнение случайными числами
                    a[i, j] = rand.Next(100);
            int MinRow, Temp;
            for (int i = 0; i < stolb; i++)
            {
                for (int NumRow = 0; NumRow < str - 1; NumRow++)
                {
                    MinRow = NumRow;
                    for (int j = NumRow + 1; j < str; j++)
                        if (a[j, i] > a[MinRow, i])
                            MinRow = j;
                    Temp = a[NumRow, i];
                    a[NumRow, i] = a[MinRow, i];
                    a[MinRow, i] = Temp;
                }
            }
            // вывод массива
            for (int r = 0; r < str; r++)
            {
                for (int c = 0; c < stolb; c++)
                {
                    Console.Write("{0}\t", a[r, c]);
                }
                Console.Write("\n");
            }
            Console.ReadKey();
        }
    }
}
