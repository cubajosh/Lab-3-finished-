using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    abstract class Account : IAccount
    {
        double balance;
        double anualint;
        double monthCharge;
        double curbalance;
        double numWithdrawl;
        double numDeposits;


        public Account(double balance, double anualint, double monthCharge)
        {
            this.balance = balance;
            this.anualint = anualint;
            this.monthCharge = monthCharge;

        }

        public double Balance { get; set; }

        public double AnualInt { get; set; }

        public double MonthCharge { get; set; }

        public int NumDeposits { get; set; }

        public int NumWithdrawls { get; set; }



        public void CalculateInterest()
        {
            double monthlyInt;

            monthlyInt = AnualInt / 12;
            monthlyInt = balance * monthlyInt;
            curbalance = balance - monthlyInt;

        }

        public string CloseAndReport()
        {

            curbalance = balance -= monthCharge;
            CalculateInterest();
            numWithdrawl = 0;
            numDeposits = 0;

            double percent = balance / curbalance * 100;

            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Current Balance: {0:C} \nPrevious Balance: {1:C} \nPercentage difference: {2} \nAdditional Interest: {3}", curbalance, balance, percent, AnualInt);
            return sb.ToString();
        }

        public void MakeDeposit(double amount)
        {
            curbalance += amount;
            numDeposits++;

        }

        public void MakeWithdrawl(double amount)
        {
            curbalance -= amount;
            NumWithdrawls++;
        }
    }
}
