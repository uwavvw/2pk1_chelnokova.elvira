using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_21
{
    internal class Account
    {
        public int ID;
        public string email;
        public string login;
        public string pass;
        public string registrationDate;

        public Account()
        {
            ID = 000;
            email = "elvira.chelnokova05@gmail.com";
            login = "89234990321";
            pass = "Okei2023!";
            registrationDate = "02.02.2023";
            Console.WriteLine("Информация об аккаунте студента: ");
        }
        public void PrintInfo()
        {
            Console.WriteLine($"ID студента: {ID}\nЕmail студента: {email}\nЛогин студента: {login}\nПароль студента: {pass}\nДата регистрации студента:{registrationDate}");
        }
    }
}
