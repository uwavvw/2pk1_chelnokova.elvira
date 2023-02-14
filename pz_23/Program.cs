using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DeletedAccount acc1 = new DeletedAccount();
            acc1.Id = 0;
            acc1.Email1 = "elvira.chelnokova05@gmail.com";
            acc1.Login1 = "89234990321";
            acc1.Pass1 = "Okei2023!";
            acc1.RegistrationDate1 = new DateTime(2021, 06, 12);

            DeletedAccount acc2 = new DeletedAccount();
            acc2.Id = 2;
            acc2.Email1 = "ivan.asidjaid@gmail.com";
            acc2.Login1 = "89542342351";
            acc2.Pass1 = "Password3@";
            acc2.RegistrationDate1 = new DateTime(2021, 06, 12);

            DeletedAccount acc3 = new DeletedAccount();
            acc3.Id = 3;
            acc3.Email1 = "mishaaaxbemid@gmail.com";
            acc3.Login1 = "89568935789";
            acc3.Pass1 = "Vjsdf239#";
            acc3.RegistrationDate1 = new DateTime(2019, 04, 07);

            acc1.PrintIhfo();
            acc2.PrintIhfo();
            acc3.PrintIhfo();
            Console.ReadKey();
        }
    }
}
