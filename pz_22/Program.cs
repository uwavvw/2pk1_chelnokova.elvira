using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace pz_22
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Account acc1 = new Account();
            acc1.Id = 1;
            acc1.Email1 = "elvira.chelnokova05@gmail.com";
            acc1.Login1 = "89234990321";
            acc1.Pass1 = "Okei2023!";
            acc1.RegistrationDate1 = new DateTime(2021, 06, 09);
            Account.accountCheck();

            Account acc2 = new Account();
            acc2.Id = 2;
            acc2.Email1 = "ivan.asidjaid@gmail.com";
            acc2.Login1 = "89542342351";
            acc2.Pass1 = "Password3@";
            acc2.RegistrationDate1 = new DateTime(2021, 06, 12);
            Account.accountCheck();

            Account acc3 = new Account();
            acc3.Id = 2;
            acc3.Email1 = "mishaaaxbemid@gmail.com";
            acc3.Login1 = "89568935789";
            acc3.Pass1 = "Vjsdf239#";
            acc3.RegistrationDate1 = new DateTime(2021, 04, 07);
            Account.accountCheck();

            Console.ReadKey();
        }
    }
}
    