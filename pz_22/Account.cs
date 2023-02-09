using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_22
{
    internal class Account
    {
        public int id;
        public string email;
        public string login;
        public string pass;
        DateTime registrationDate;
        public string email1;
        public string login1;
        public string pass1;
        DateTime registrationDate1;
        DateTime minDate = new DateTime(2000, 01, 01);
        DateTime maxDate = new DateTime(2022, 01, 01);
       
        public Account()
        {
            id = int.Parse(Console.ReadLine());
            email = "elvira.chelnokova05@gmail.com";
            login = "89234990321";
            pass = "Okei2023!";
            registrationDate = new DateTime (1987, 06, 12);
            email1 = "ivan.asidjaid@gmail.com";
            login1 = "89542342351";
            pass1 = "Password@83";
            registrationDate1 = new DateTime(2019, 10, 10);
            
        }
         public DateTime RegistrationDate
         {
            set
            {
                if (value > minDate || value < maxDate)
                {
                    registrationDate = value;
                }
                Console.WriteLine("дата не подходит");
            }
            get { return registrationDate; }  
         }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }



        public void PrintInfo()
        {
           
            if (id == 1)
            {
                Console.WriteLine($"ID студента: {id}\nЕmail студента: {email}\nЛогин студента: {login}\nПароль студента: {pass}\nДата регистрации студента: {registrationDate}");
            }
            else if (id == 2)
            {
                Console.WriteLine($"ID студента: {id}\nЕmail студента: {email1}\nЛогин студента: {login1}\nПароль студента: {pass1}\nДата регистрации студента: {registrationDate1}");
            }
            else
                Console.WriteLine($"Номера студента не существует");
            
        }
    }
}
