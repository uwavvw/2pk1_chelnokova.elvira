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
        public int id;
        public string pattern = @"^(?=.*\d)(?=.*[a-zA-Z])(?=.*[!#@]).{8,}$";
        //1
        private string email1;
        private string login1;
        private string pass1;
        DateTime registrationDate1;
        //2
        private string email2;
        private string login2;
        private string pass2;
        DateTime registrationDate2;
        //3
        private string email3;
        private string login3;
        private string pass3;
        DateTime registrationDate3;
        DateTime minDate = new DateTime(2000, 01, 01);
        DateTime maxDate = new DateTime(2022, 01, 01);
       
        public Account()
        {
            Id = int.Parse(Console.ReadLine());
            //1 
            Email1 = "elvira.chelnokova05@gmail.com";
            Login1 = "89234990321"; 
            Pass1 = "Okei2023!";
            RegistrationDate1 = new DateTime (2021, 06, 12);
            //2
            Email2 = "ivan.asidjaid@gmail.com";
            Login2 = "89542342351";
            Pass2 = "Password3@";
            RegistrationDate2 = new DateTime(2019, 10, 10);
            //3
            Email3 = "mishaaaxbemid@gmail.com";
            Login3 = "89568935789";
            Pass3 = "Vjsdf239#";
            RegistrationDate3 = new DateTime(2020, 04, 07);

        }
        
        
        public int Id
        {
            get { return id; }
            set
            {   if (value == 0 || value > 3)
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
            get { return pass1; }
            set 
            {
                if (Regex.IsMatch(value, pattern)) //создаем цикл в котором проверяем обнаружено ли в указанной входной строке соответствие заданному
                {
                    pass1 = value;
                }
                else
                {
                    Console.WriteLine("пароль не подходит");
                }
            }
        }//свойство для проверки пароля акк 01
        public string Pass2
        {
            get { return pass1; }
            set
            {
                if (Regex.IsMatch(value, pattern)) //создаем цикл в котором проверяем обнаружено ли в указанной входной строке соответствие заданному
                {
                    pass1 = value;
                }
                else
                {
                    Console.WriteLine("пароль не подходит");
                }
            }
        }//свойство для проверки пароля акк 02
        public string Pass3
        {
            get { return pass3; }
            set
            {
                if (Regex.IsMatch(value, pattern)) //создаем цикл в котором проверяем обнаружено ли в указанной входной строке соответствие заданному
                {
                    pass3 = value;
                }
                else
                {
                    Console.WriteLine("пароль не подходит");
                }
            }
        }//свойство для проверки пароля акк 03
        public string Login1
        {
            get { return login1; }
            set
            {
                if (value == "") //создаем цикл в котором проверяем обнаружено ли в указанной входной строке соответствие заданному
                {
                    Console.WriteLine("логина не существует");
                }
                else
                {
                    login1 = value; 
                }
            }
        }//свойство для проверки логина акк 01
        public string Login2
        {
            get { return login2; }
            set
            {
                if (value == "") //создаем цикл в котором проверяем обнаружено ли в указанной входной строке соответствие заданному
                {
                    Console.WriteLine("логина не существует");
                }
                else
                {
                    login2 = value;
                }
            }
        }//свойство для проверки логина акк 02
        public string Login3
        {
            get { return login3; }
            set
            {
                if (value == "") //создаем цикл в котором проверяем обнаружено ли в указанной входной строке соответствие заданному
                {
                    Console.WriteLine("логина не существует");
                }
                else
                {
                    login3 = value;
                }
            }
        }//свойство для проверки логина акк 03
        public string Email1
        {
            get { return email1; }
            set
            {
                if (value == "") //создаем цикл в котором проверяем обнаружено ли в указанной входной строке соответствие заданному
                {
                    Console.WriteLine("почта не существует");
                }
                else
                {
                    email1 = value;
                }
            }
        }//свойство для проверки почты акк 01
        public string Email2
        {
            get { return email2; }
            set
            {
                if (value == "") //создаем цикл в котором проверяем обнаружено ли в указанной входной строке соответствие заданному
                {
                    Console.WriteLine("почта не существует");
                }
                else
                {
                    email2 = value;
                }
            }
        }//свойство для проверки почты акк 02
        public string Email3
        {
            get { return email3; }
            set
            {
                if (value == "") //создаем цикл в котором проверяем обнаружено ли в указанной входной строке соответствие заданному
                {
                    Console.WriteLine("почта не существует");
                }
                else
                {
                    email3 = value;
                }
            }
        }//свойство для проверки почты акк 03
        public DateTime RegistrationDate1
        {
            get { return registrationDate1; }
            set
            {
                if (value > minDate && value < maxDate) 
                {
                    registrationDate1 = value; 
                }
                else
                {
                    Console.WriteLine("дата не входит в диапазон");
                }
            }
        }//свойство для проверки даты акк 01
        public DateTime RegistrationDate2
        {
            get { return registrationDate2; }
            set
            {
                if (value > minDate && value < maxDate) 
                {
                    registrationDate2 = value;
                }
                else
                {
                    Console.WriteLine("дата не входит в диапазон");
                }
            }
        }//свойство для проверки даты акк 02
        public DateTime RegistrationDate3
        {
            get { return registrationDate3; }
            set
            {
                if (value > minDate && value < maxDate)
                {
                    registrationDate3 = value;
                }
                else
                {
                    Console.WriteLine("дата не входит в диапазон");
                }
            }
        }//свойство для проверки даты акк 03



        public void PrintInfo()
        {
            if(id == 1)
            Console.WriteLine($"ID студента: {id}\nЕmail студента: {email1}\nЛогин студента: {login1}\nПароль студента: {pass1}\nДата регистрации студента: {registrationDate1}");
            else if (id == 2 )
                Console.WriteLine($"ID студента: {id}\nЕmail студента: {email2}\nЛогин студента: {login2}\nПароль студента: {pass2}\nДата регистрации студента: {registrationDate2}");
            else if (id == 3)
                Console.WriteLine($"ID студента: {id}\nЕmail студента: {email3}\nЛогин студента: {login3}\nПароль студента: {pass3}\nДата регистрации студента: {registrationDate3}");
            else
                Console.WriteLine("аккаунта не существует");
        }
        
    }
}
