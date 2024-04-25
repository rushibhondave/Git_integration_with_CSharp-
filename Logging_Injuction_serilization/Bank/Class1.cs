﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class bank_info
    {

        public bank_info() 
        {
            Console.WriteLine("Enter the Customer Count you want to store");
            int NUM_Customer = Convert.ToInt32(Console.ReadLine()); 
            const int DATA_SIZE = 4; //  Name,Age,Account_type,Deposite,

            string[,] players = new string[NUM_Customer, DATA_SIZE];

        
            for (int i = 0; i < NUM_Customer; ++i)
            {
                Console.WriteLine($"Enter details for Player {i + 1}:");
                for (int j = 0; j < DATA_SIZE; ++j)
                {
                    switch (j)
                    {
                        case 0:
                            Console.Write("Name: ");
                            break;
                        case 1:
                            Console.Write("Age: ");
                            break;
                        case 2:
                            Console.Write("Account Type: ");
                            break;
                        case 3:
                            Console.Write("Deposite: ");
                            break;
                    }
                    players[i, j] = Console.ReadLine();
                }
            }


            Console.WriteLine("\nPlayer Data:");
            for (int i = 0; i < NUM_Customer; ++i)
            {
                Console.WriteLine($"Player {i + 1}:");
                for (int j = 0; j < DATA_SIZE; ++j)
                {
                    switch (j)
                    {
                        case 0:
                            Console.Write("Name: ");
                            break;
                        case 1:
                            Console.Write("ID: ");
                            break;
                        case 2:
                            Console.Write("Role: ");
                            break;
                        case 3:
                            Console.Write("Runs: ");
                            break;
                    }
                    Console.WriteLine(players[i, j]);
                }
                Console.WriteLine();
            }

        }
    }
}


  
