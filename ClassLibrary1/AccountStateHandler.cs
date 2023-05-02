using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{


    public delegate void AccountStateHandler(object sender, AccountEventArgs e);

    public class AccountEventArgs
    {
        public string Massage { get; set; }
        public int Sum { get; private set; }

        public AccountEventArgs(int a, string sms)
        {
            Sum = a;
            Massage = sms;
        }
    }
    
}
