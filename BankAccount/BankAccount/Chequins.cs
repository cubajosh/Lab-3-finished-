using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Chequins : Account
    {


        public Chequins(double balance, double anualint, double monthCharge) : base(balance, anualint, monthCharge)
        {
            

        }

        public double makeWithdrawl(double amount)
        {
            double Charge = 5.00;

            if(Balance > 0)
            {
                Balance -= amount;
            }
            else if(Balance < 0)
            {
                Balance -= Charge;

                Console.WriteLine("Unable to Make Withdrawl due to Insuficiant funds");
                Console.WriteLine("Current Balance owed: -{0:C}", Balance);
                Console.ReadLine();
            }
            NumWithdrawls++;
            return Balance;
        }

        public string closeAndReport(double charge)
        {
            base.MonthCharge = 3.99;

            if (base.NumWithdrawls >= 1)
            {
                _= base.MonthCharge + .10;
            }

            double curbalance = base.Balance - MonthCharge - NumWithdrawls;

            string str = base.CloseAndReport();
            return str;
        }
        public double makeDeposit(double amount)
        {
            Balance += amount;
            NumDeposits++;

            return Balance;
        }
    }
}
