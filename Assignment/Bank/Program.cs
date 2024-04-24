using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Project1
{
    internal class Program
    {
        private static object deposite;
        static void Main(string[] args)
        {
            int withdraw, deposit, choice, total_amount = 0;
            String ch;
            do
            {
                Console.WriteLine("Enter choice: 1.Deposit  2.Withdraw 3.total_amount 4.Exit");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            Console.WriteLine("Enter Amount to deposit: ");
                            deposit = Convert.ToInt32(Console.ReadLine());
                            total_amount = total_amount + deposit;
                            Console.WriteLine("Total amount after deposit:" + total_amount);
                            break;
                        }
                    case 2:
                        Console.WriteLine("Enter Amount to withdraw: ");
                        withdraw = Convert.ToInt32(Console.ReadLine());
                        total_amount = total_amount - withdraw;
                        Console.WriteLine("Total amount after withraw:" + total_amount);
                        break;
                    case 3:
                        Console.WriteLine("Total amount: " + total_amount);
                        break;
                        #region Exit Code
                        //case 4:
                        //  Console.WriteLine("Thank you for visiting");
                        //  Thread.Sleep(2000);
                        //  System.Environment.Exit(0);
                        //  break; 
                        #endregion
                }
                Console.WriteLine("Do you want to continue ? ");
                ch = Console.ReadLine();
            }
            while (ch == "y");
        }
    }
}