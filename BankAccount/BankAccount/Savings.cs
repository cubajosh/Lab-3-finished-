using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Savings : Account
    {
        bool active;

        public Savings(double balance, double anualint, double monthCharge, bool active) : base(balance, anualint, monthCharge)
        {
            this.active = active;

        }

        public double makeWithdrawl(double amount)
        {

            if(base.Balance > 0)
            {
                active = true;

                base.Balance -= amount;

            }else if(base.Balance == 0)
            {
                active = false;
                Console.WriteLine("savings Account is Unactive");
            }else if(base.Balance < 0)
            {
                Console.WriteLine("Insuficient Funds");
            }
            NumWithdrawls++;
            return base.Balance;
        }
        public double makeDeposit(double amount)
        {
            if (active.Equals(true))
            {
                base.Balance += amount;
                NumDeposits++;
            }
            else if (active.Equals(false) || Balance > 25)
            {
                active = true;
                base.Balance += amount;
                NumDeposits++;
            }
            return Balance;
        }
        public string closeAndReport()
        {
            int withdrawlsOverFour = base.NumWithdrawls - 4;

            if (withdrawlsOverFour > 0)
            {
                _ = base.MonthCharge + withdrawlsOverFour;
            }

            double curbalance = base.Balance - withdrawlsOverFour;

            string str = base.CloseAndReport();
            return str;
        }

    }
}
