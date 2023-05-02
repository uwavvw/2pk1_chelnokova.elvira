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
        public decimal Massage { get; set; }
        public string Sum { get; private set; }

        public AccountEventArgs(string a, decimal sms)
        {
            Sum = a;
            Massage = sms;
        }
    }
    
}
