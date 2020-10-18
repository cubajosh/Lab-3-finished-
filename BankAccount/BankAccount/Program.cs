using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    class Program
    {
        static void Main(string[] args)
        {
            Chequins check = new Chequins(25.00, 0.12, 3.99);
            Savings save = new Savings(25.00, 0.12, 3.99,true);
            GlobalSavingsAccount gsa = new GlobalSavingsAccount(25.00, 0.12, 3.99,true);

            bool loop = true;
            while (loop == true)
            {

                StringBuilder sb = new StringBuilder();

                sb.AppendFormat("***Welcome to Scotia Bank Personal Banking***\n***Bank Menu***\nA.Savings Account\nB.Checkings Account\nC.Gloabl Savings Account\nQ.Quit");
                Console.WriteLine(sb);
                string line = Console.ReadLine();

                if (line.Equals("Q", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }

 

                    switch (line.ToLower())
                    {

                        case "a":
                            Console.WriteLine("***Savings Menu***");
                            Console.WriteLine("A. Deposit");
                            Console.WriteLine("B. withdrawl");
                            Console.WriteLine("C. Close and Report");
                            Console.WriteLine("R. Return to Menu");
                            string mainInp1 = Console.ReadLine();


                            switch (mainInp1.ToLower())
                            {

                                case "a":


                                    Console.WriteLine("How much would you like to deposit?");
                                    double sav1 = Convert.ToDouble(Console.ReadLine());

                                    Console.WriteLine("Your Balance is now: {0}", save.makeDeposit(sav1));
                                    Console.WriteLine("Press any key to continue");
                                    string user = Console.ReadLine();

                                    if (user.Equals(ConsoleKey.Y))
                                    {
                                        continue;
                                    }
                                    break;
                                case "b":
                                    Console.WriteLine("How much would you like to withdrawl?");
                                    double sav2 = Convert.ToDouble(Console.ReadLine());

                                    Console.WriteLine("Your Balance is now: {0}", save.makeWithdrawl(sav2));
                                    Console.WriteLine("press any key to continue");
                                    string user1 = Console.ReadLine();

                                    if (user1.Equals(ConsoleKey.Y))
                                    {
                                        continue;
                                    }

                                    break;
                                case "c":
                                    Console.WriteLine("Close and report Status: ");
                                    string sav3 = save.closeAndReport();
                                    Console.WriteLine(sav3);

                                    Console.WriteLine("press any key to continue");
                                    string user2 = Console.ReadLine();

                                    if (user2.Equals(ConsoleKey.Y))
                                    {
                                        continue;
                                    }
                                    break;
                                case "r":
                                    if (mainInp1.Equals(ConsoleKey.R))
                                    {
                                        Console.WriteLine(sb);
                                        line = Console.ReadLine();
                                    }
                                    break;

                            }
                            break;


                        case "b":
                            Console.WriteLine("***Checkings Menu***");
                            Console.WriteLine("A. Deposit");
                            Console.WriteLine("B. withdrawl");
                            Console.WriteLine("C. Close and Report");
                            Console.WriteLine("R. Return to Menu");

                            string mainInp2 = Console.ReadLine();

                            switch (mainInp2.ToLower())
                            {

                                case "a":
                                    Console.WriteLine("How much would you like to deposit?");
                                    double check1 = Convert.ToDouble(Console.ReadLine());

                                    Console.WriteLine("Your Balance is now: {0}", check.makeDeposit(check1));
                                    Console.WriteLine("Press any key to continue");
                                    string user1 = Console.ReadLine();

                                    while (user1.Equals(ConsoleKey.Y))
                                    {
                                        continue;
                                    }
                                    break;
                                case "b":
                                    Console.WriteLine("How much would you like to withdrawl?");
                                    double check2 = Convert.ToDouble(Console.ReadLine());

                                    Console.WriteLine("Your Balance is now: {0}", check.makeWithdrawl(check2));
                                    Console.WriteLine("Press any key to continue");
                                    string user2 = Console.ReadLine();

                                    while (user2.Equals(ConsoleKey.Y))
                                    {
                                        continue;
                                    }
                                    break;

                                case "c":
                                    Console.WriteLine("Close and report Status: ");
                                    string check3 = check.closeAndReport(3.99);
                                    Console.WriteLine(check3);
                                    Console.WriteLine("Press any key to continue");
                                    string user3 = Console.ReadLine();

                                    while (user3.Equals(ConsoleKey.Y))
                                    {
                                        continue;
                                    }
                                    break;
                                case "r":
                                    if (mainInp2.Equals(ConsoleKey.R))
                                    {
                                        Console.WriteLine(sb);
                                        line = Console.ReadLine();
                                    }
                                    break;
                            }



                            break;
                        case "c":
                            Console.WriteLine("***Global Savings Menu***");
                            Console.WriteLine("A. Deposit");
                            Console.WriteLine("B. withdrawl");
                            Console.WriteLine("C. Close and Report");
                            Console.WriteLine("D.Report Balance in USD");
                            Console.WriteLine("R. Return to Menu");
                            string mainInp3 = Console.ReadLine();

                            switch (mainInp3.ToLower())
                            {

                                case "a":
                                    Console.WriteLine("How much would you like to deposit?");
                                    double gsa1 = Convert.ToDouble(Console.ReadLine());

                                    Console.WriteLine("Your Balance is now: {0}", gsa.makeDeposit(gsa1));

                                    Console.WriteLine("Press any key to continue");
                                    string user1 = Console.ReadLine();

                                    if (user1.Equals(ConsoleKey.Y))
                                    {
                                        continue;
                                    }
                                    break;

                                case "b":
                                    Console.WriteLine("How much would you like to withdrawl?");
                                    double gsa2 = Convert.ToDouble(Console.ReadLine());

                                    Console.WriteLine("Your Balance is now: {0}", gsa.makeWithdrawl(gsa2));

                                    Console.WriteLine("Press any key to continue");
                                    string user2 = Console.ReadLine();

                                    while (user2.Equals(ConsoleKey.Y))
                                    {
                                        continue;
                                    }
                                    break;
                                case "c":
                                    Console.WriteLine("Close and report Status: ");
                                    string gsa3 = gsa.closeandReport();
                                    Console.WriteLine(gsa3);
                                    Console.WriteLine("Press any key to continue");
                                    string user3 = Console.ReadLine();

                                    if (user3.Equals(ConsoleKey.Y))
                                    {
                                        continue;
                                    }
                                    else if (user3.Equals(ConsoleKey.N))
                                    {
                                        break;
                                    }
                                    break;
                                case "d":
                                    Console.WriteLine("your amount in USD is: {0}", gsa.USValue(0.75));
                                    Console.WriteLine("Press any key to continue");
                                    string user4 = Console.ReadLine();

                                    if (user4.Equals(ConsoleKey.Y))
                                    {
                                        continue;
                                    }
                                    break;
                                case "r":
                                    if (mainInp3.Equals(ConsoleKey.R))
                                    {
                                        Console.WriteLine(sb);
                                        line = Console.ReadLine();
                                    }
                                    break;
                            }

                            break;
                        case "q":
                            break;
                    }
                

            }

        }
    }
}

  
    

