using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_24
{
    internal class Program 
    {
        static void Main(string[] args) 
        {
            DeletedAccount acc1 = new DeletedAccount();
            acc1.Id = 4;
            acc1.Email1 = "elvira.chelnokova05@gmail.com";
            acc1.Login1 = "89234990321";
            acc1.Pass1 = "Okei2023!";
            acc1.RegistrationDate1 = new DateTime(2021, 06, 12);
            DeletedAccount accountClone = (DeletedAccount)acc1.Clone();

            DeletedAccount acc2 = new DeletedAccount();
            acc2.Id = 2;
            acc2.Email1 = "ivan.asidjaid@gmail.com";
            acc2.Login1 = "89542342351";
            acc2.Pass1 = "Password3@";
            acc2.RegistrationDate1 = new DateTime(2021, 06, 12);
            DeletedAccount accountClone2 = (DeletedAccount)acc2.Clone();

            DeletedAccount acc3 = new DeletedAccount();
            acc3.Id = 3;
            acc3.Email1 = "mishaaaxbemid@gmail.com";
            acc3.Login1 = "89568935789";
            acc3.Pass1 = "Vjsdf239#";
            acc3.RegistrationDate1 = new DateTime(2019, 04, 07);
            DeletedAccount accountClone3 = (DeletedAccount)acc3.Clone();

            acc1.PrintIhfo();
            acc2.PrintIhfo();
            acc3.PrintIhfo();

            acc1.Id = 1;
            acc2.Id = 5;
            acc3.Id = 6;
            Console.WriteLine($"\nклонированные объекты остались без изменений 1: {accountClone.Id}\nклонированные объекты остались без изменений 2: {accountClone2.Id}\nклонированные объекты остались без изменений 3: {accountClone3.Id}\n");
            Console.WriteLine($"клонированные объекты c изменениями 1: {acc1.Id}\nклонированные объекты c изменениями 2: {acc2.Id}\nклонированные объекты c изменениями 3: {acc3.Id}\n");
            Console.ReadKey();
            
        }
    }
}
