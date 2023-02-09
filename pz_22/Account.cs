using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_22
{
    internal class Account
    {
        private int id;
        public string pattern = @"([A - Z]+\W\w+)";
        //1
        private string email;
        private string login;
        private string pass;
        DateTime registrationDate;
        //2
        private string email1;
        private string login1;
        private string pass1;
        DateTime registrationDate1;
        //3
        private string email2;
        private string login2;
        private string pass2;
        DateTime registrationDate2;
        DateTime minDate = new DateTime(2000, 01, 01);
        DateTime maxDate = new DateTime(2022, 01, 01);
       
        public Account()
        {
            id = int.Parse(Console.ReadLine());
            //1 
            email = "elvira.chelnokova05@gmail.com";
            login = "89234990321";
            Pass = "Okei2023!";
            //pass = "Okei2023!";
            registrationDate = new DateTime (1987, 06, 12);
            //2
            email1 = "ivan.asidjaid@gmail.com";
            login1 = "89542342351";
            pass1 = "Password@83";
            registrationDate1 = new DateTime(2019, 10, 10);
            //3
            email2 = "mishaaaxbemid@gmail.com";
            login2 = "89568935789";
            pass2 = "Vjsdf239#";
            registrationDate2 = new DateTime(2023, 04, 07);

        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        
        public string Pass
        {
            get { return pass; }
            set 
            { 
                    for (int i = 0; i < pass.Length; i++)
                    {
                        if (pass.Length >= 8)
                        {

                        }
                    }
                    pass = value;
                
            }
        }




        public void PrintInfo()
        {
           
            /*if (id == 1)
            {
                Console.WriteLine($"ID студента: {id}\nЕmail студента: {email}\nЛогин студента: {login}\nПароль студента: {pass}\nДата регистрации студента: {registrationDate}");
            }
            else if (id == 2)
            {
                Console.WriteLine($"ID студента: {id}\nЕmail студента: {email1}\nЛогин студента: {login1}\nПароль студента: {pass1}\nДата регистрации студента: {registrationDate1}");
            }
            else
                Console.WriteLine($"Номера студента не существует");*/
            
        }
    }
}
