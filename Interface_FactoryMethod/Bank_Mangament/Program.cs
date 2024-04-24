//namespace FactoryMethod
//{
//    internal class Program
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Hi i am Rushikesh ");
//            Console.ReadKey();
//        }
//    }

//}


using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
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

            Console.WriteLine("How much Custemer data do you want to store here?");
            int n = Convert.ToInt32(Console.ReadLine());
            int mul = n * 20;
            string[] depositName = new string[mul];
            int[] withdraw = new int[mul];
            int[] depositAmount = new int[mul];
            string[] withdrawName = new string[mul];
            int[] deposit = new int[mul];
            int choice, temp = 0, total_amount = 500;
            int temp12 = 0, cnt = 0; ;
            String ch;
            do
            {
                Console.Write("\n\tEnter choice: 1.Deposit  2.Withdraw 3.total_amount 4.(last 5 transition)  5.Exit :");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        {
                            Console.WriteLine("\n\t\t********* Welcome to the Deposit procedure ::********* \n");
                            Console.WriteLine("Enter the Nominee  Name  ");
                            for (int i = 0; i < n; i++)
                            {
                                Console.Write($"\nNominee Name :: {i + 1}:");
                                depositName[i] = Console.ReadLine();

                                Console.WriteLine("\nEnter the Amount you want to deposit ");
                                int no = 0;
                                int nn = 0;

                                do
                                {

                                    for (int k = 0; k <= nn; k++)
                                    {

                                        Console.Write($"\nDeposite Amount :: {k + 1}: ");
                                        deposit[k] = Convert.ToInt32(Console.ReadLine());
                                        Console.Write($"\nYou want to continue Deposite your amount again :: {k + 1}: 1.Yes or 2.No : ");
                                        no = Convert.ToInt32(Console.ReadLine());
                                        if (no == 1)
                                        {
                                            nn++;
                                        }
                                        cnt++;
                                    }



                                    temp12 = cnt;
                                } while (no != 2);



                            }

                        }

                        Console.WriteLine("\n\t\t********* Succsfullly Data Insert ....! *********");
                        Console.WriteLine();
                        break;

                    case 2:
                        {
                            Console.WriteLine("\n\n\t\t*********Welcome to the Withdraw procedure ::********* \n");
                            Console.WriteLine("\nAvailable Balance ::" + total_amount);

                            Console.WriteLine("\nGive me a withdraw amount for cheacking Balance: ");
                            int noo = Convert.ToInt32(Console.ReadLine());
                            if (noo > total_amount)
                            {
                                Console.WriteLine("\nNot suffisent balance on your Account....!\n");
                            }
                            else
                            {
                                Console.WriteLine("\nSuffisent balance on your Account Withdraw procedure Start....!\n");
                                Console.WriteLine("Enter the Nominee  Name  ");
                                for (int i = 0; i < n; i++)
                                {
                                    Console.Write($"\nNominee Name :: {i + 1}:");
                                    withdrawName[i] = Console.ReadLine();

                                    int nn = 0;
                                    int no = 0;
                                    do
                                    {

                                        for (int k = 0; k <= nn; k++)
                                        {
                                            Console.Write($"Withdraw Amount::  {k + 1}: ");
                                            withdraw[k] = Convert.ToInt32(Console.ReadLine());
                                            temp = withdraw[k];

                                            Console.Write($"\nYou want to continue Deposite your amount again :: 1.Yes or 2.No : ");
                                            no = Convert.ToInt32(Console.ReadLine());
                                            if (no == 1)
                                            {
                                                nn++;
                                            }
                                            cnt++;
                                        }

                                        temp12 = cnt;

                                        total_amount -= temp;

                                    } while (no != 2);

                                }
                            }
                            //Console.WriteLine("\nTotal amount after WithdraW:" + total_amount);
                            Console.WriteLine("\t\t\n****************Thank you for visiting****************\n");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Total amount: " + total_amount);
                        break;

                    case 4:
                        {
                            Console.Write("\nShow last 5 trastion choose  1.Deposite 2.Withdraw");
                            int sum = Convert.ToInt32(Console.ReadLine());
                            if (sum == 1)
                            {
                                Console.WriteLine("\nDisplay Deposite Data::");
                                for (int i = 0; i <= temp12; i++)
                                {
                                    Console.WriteLine($"Nominee  Name:: {i + 1}: {depositName[i]}");
                                    Console.WriteLine($"deposit Amount:: {i + 1}: {deposit[i]}");
                                    Console.WriteLine("\n");



                                }
                            }
                            else
                            {
                                Console.WriteLine("Display  Withdraw Data::");
                                for (int i = 0; i <= temp12; i++)
                                {
                                    Console.WriteLine($"Nominee  Name:: {i + 1}: {withdrawName[i]}");
                                    Console.WriteLine($"Withdraw Amount:: {i + 1}: {withdraw[i]}");
                                    Console.WriteLine("\n");
                                }
                            }
                        }
                        break;
                    case 5:
                        System.Environment.Exit(0);
                        break;


                }
                Console.WriteLine("Do you want to continue ? ");
                ch = Console.ReadLine();
            }
            while (ch == "y");
        }
    }
}