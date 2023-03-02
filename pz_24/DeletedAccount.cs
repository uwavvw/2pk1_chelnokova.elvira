using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pz_24
{
    internal class DeletedAccount : Account, IClonable
    {
        DateTime aa = new DateTime(0001, 01, 01);
        
        public int Id
        {
            get { return id; }
            set
            {
                if (value == 0)
                {
                    Console.WriteLine("");
                }
                else
                {
                    id = value;
                }
            }
        }
        public override string Login1
        {
            get { return login; }
            set
            {
                if (value == "")
                {
                    Console.WriteLine("");
                }
                else
                {
                    login = value;
                }
            }
        }//свойство для проверки логина акк 
        public string Pass1
        {
            get { return pass; }
            set
            {
                if (value == "")
                    Console.WriteLine("пароля не существует, аккаунт удален");
                else
                    pass = value;
            }

        } //свойство для проверки пароля акк 
        public DateTime RegistrationDate1
        {
            get { return registrationDate; }
            set
            {
                if (value == aa)
                {
                    Console.WriteLine("");
                }
                else
                {
                    registrationDate = value;
                }

            }
        }//свойство для проверки даты акк 
        public override string Email1
        {
            get { return email; }
            set
            {
                if (value == "")
                {
                    Console.WriteLine("");
                }
                else
                {
                    email = value;
                }
            }
        }
        public void PrintIhfo()
        {
            if (id == 0 || login == "" || pass == "" || email == "" || registrationDate == aa)
            {
                Console.WriteLine("аккаунта не существует");
            }
            else
                Console.WriteLine($"ID: {Id}\nпочта: {Email1}\nлогин: {Login1}\nпароль:  {Pass1}\nдата регистрации: {RegistrationDate1}");
        }
        public new object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}

