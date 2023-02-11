using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace pz_22
{
    internal class Account
    {
        private int id;
        public string pattern = @"^(?=.*\d)(?=.*[a-zA-Z])(?=.*[!#@]).{8,}$";
        DateTime minDate = new DateTime(2000, 01, 01);
        DateTime maxDate = new DateTime(2022, 01, 01);
        public static int count;
        private string email;
        private string login;
        private string pass;
        static DateTime registrationDate;

        public static void accountCheck()
        {
            DateTime date = new DateTime(2020, 01, 01);
            if (date < registrationDate)
            {
                count++;
                
                Console.WriteLine($"ID аккаунта, который зарегестировался после 2020 года: {count}");
            }
            else
                 Console.WriteLine("аккаунт зарегестирован раньше 2020 года");
            
        }
        public int Id
        {
            get { return id; }
            set
            {
                if (value == 0 || value > 3)
                {
                    Console.WriteLine("ID не совпадает");
                }
                else
                {
                    id = value;
                }
            }
        }
        public string Pass1
        {
            get { return pass; }
            set
            {
                if (Regex.IsMatch(value, pattern)) //создаем цикл в котором проверяем обнаружено ли в указанной входной строке соответствие заданному
                {
                    pass = value;
                }
                else
                {
                    Console.WriteLine("пароль не подходит");
                }
            }
        }//свойство для проверки пароля акк 
        public string Login1
        {
            get { return login; }
            set
            {
                if (value == "") //создаем цикл в котором проверяем обнаружено ли в указанной входной строке соответствие заданному
                {
                    Console.WriteLine("логина не существует");
                }
                else
                {
                    login = value;
                }
            }
        }//свойство для проверки логина акк 
        public string Email1
        {
            get { return email; }
            set
            {
                if (value == "") //создаем цикл в котором проверяем обнаружено ли в указанной входной строке соответствие заданному
                {
                    Console.WriteLine("почта не существует");
                }
                else
                {
                    email = value;
                }
            }
        }//свойство для проверки почты акк 
        public DateTime RegistrationDate1
        {
            get { return registrationDate; }
            set
            {
                if (value > minDate && value < maxDate)
                {
                    registrationDate = value;
                }
                else
                {
                    Console.WriteLine("дата не входит в диапазон");
                }
            }
        }//свойство для проверки даты акк 

    }
}
