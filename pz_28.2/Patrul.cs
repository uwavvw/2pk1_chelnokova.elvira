using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_28._2
{
    internal class Patrul
    {
        public int chislo;
        public Patrul(int count) { chislo = count; }
        public void show(int chislo)
        {
            Console.WriteLine(chislo + " км/ч");
            if (chislo >= 80&& chislo<120)
            {
                Console.WriteLine($"Превышение скорости!!!\nСнизьте скорость!!!");
            }
            else if (chislo > 120)
            {
                Console.WriteLine($"Активирован режим задержания");
            }
            
           
        }
    }
}
