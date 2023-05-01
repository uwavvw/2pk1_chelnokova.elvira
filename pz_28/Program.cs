using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Counter obj = new Counter();
            Wait wait200 = new Wait(1);
            Wait wait800 = new Wait(1);
            obj.RaiseMyEvent(1);
            obj.Myevent += wait200.show;
            obj.RaiseMyEvent(1);
            obj.Myevent += wait800.show;

            Console.ReadLine();
        }
    }
}
// Создайте консольное приложение, в котором присутствуют два класса:
//a.Первый класс Counter генерирует последовательность чисел в цикле от 1 до 1000
//b. Объект второго класса Wait – wait200 ждет появления значения 200 и выводит
//сообщение
//c. Объект второго класса Wait – wait800 ждет появления значения 800 и выводит
//сообщение