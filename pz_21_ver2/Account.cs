using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_21_ver2
{
    internal class Account
    {
        public int ID;
        public string email;
        public string login;
        public string pass;
        public string registrationDate;
        public string email1;
        public string login1;
        public string pass1;
        public string registrationDate1;

        public Account()
        {
            ID = int.Parse(Console.ReadLine());
            email = "elvira.chelnokova05@gmail.com";
            login = "89234990321";
            pass = "Okei2023!";
            registrationDate = "02.02.2023";
            email1 = "ivan.asidjaid@gmail.com";
            login1 = "89542342351";
            pass1 = "Password@83";
            registrationDate1 = "1.02.2021";
            Console.WriteLine("Информация об аккаунте студента: ");
        }
        public void PrintInfo()
        {
            if (ID == 0)
            {
                Console.WriteLine($"ID студента: {ID}\nЕmail студента: {email}\nЛогин студента: {login}\nПароль студента: {pass}\nДата регистрации студента: {registrationDate}");
            }
            else if (ID == 1)
            {
                Console.WriteLine($"ID студента: {ID}\nЕmail студента: {email1}\nЛогин студента: {login1}\nПароль студента: {pass1}\nДата регистрации студента: {registrationDate1}");
            }
            else
                Console.WriteLine($"Номера студента не существует");
        }
    }
}
