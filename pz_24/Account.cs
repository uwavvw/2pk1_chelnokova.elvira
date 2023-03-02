using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace pz_24
{
    internal class Account : IClonable
    {
        public int id;
        public string pattern = @"^(?=.*\d)(?=.*[a-zA-Z])(?=.*[!#@]).{8,}$";
        DateTime minDate = new DateTime(2000, 01, 01);
        DateTime maxDate = new DateTime(2022, 01, 01);
        public static int count = 0;
        public string email;
        public string login;
        public string pass;
        public static DateTime registrationDate;
        
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
                if (Regex.IsMatch(value, pattern))
                    pass = value;
                else
                    Console.WriteLine("пароль не подходит");
            }

        } //свойство для проверки пароля акк 
        public virtual string Login1
        {
            get { return login; }
            set
            {
                if (value == "")
                {
                    Console.WriteLine("логина не существует");
                }
                else
                {
                    login = value;
                }
            }
        }//свойство для проверки логина акк 
        public virtual string Email1
        {
            get { return email; }
            set
            {
                if (value == "")
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

        public new object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
