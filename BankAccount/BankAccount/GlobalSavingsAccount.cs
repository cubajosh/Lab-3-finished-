using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class GlobalSavingsAccount : Savings, IExchangeable
    {

        public GlobalSavingsAccount(double balance, double anualint, double monthCharge, bool active) : base(balance, anualint, monthCharge, active)
        {

        }

        public double USValue(double rate)
        {
            rate = 1 / 1.33 * Balance;
            return rate;
        }
        public string closeandReport()
        {
            USValue(0.75);
            string str = base.CloseAndReport();
            return str;
        }
    };
}
