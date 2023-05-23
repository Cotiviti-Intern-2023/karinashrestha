using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAY_1
{
  
        class Program
        {
            static void Main(string[] args)
            {
                decimal currentBalance = 0m;

                for (int i = 1; i <= 5; i++)
                {
                    Console.WriteLine($"Transaction #{i}");

                    Console.WriteLine("Choose an action:");
                    Console.WriteLine("1. Deposit");
                    Console.WriteLine("2. Check Balance");
                    Console.WriteLine("3. Withdraw");
                    Console.Write("Enter your choice: ");
                    int choice = Convert.ToInt32(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            Console.Write("Enter the deposit amount: ");
                            decimal depositAmount = Convert.ToDecimal(Console.ReadLine());
                            if (depositAmount <= 0)
                            {
                                Console.WriteLine("Deposit amount must be greater than zero.");
                                continue;
                            }
                            currentBalance += depositAmount;
                            Console.WriteLine($"Successfully deposited {depositAmount:C}. Current balance: {currentBalance:C}");
                            break;

                        case 2:
                            Console.WriteLine($"Current balance: {currentBalance:C}");
                            break;

                        case 3:
                            Console.Write("Enter the withdrawal amount: ");
                            decimal withdrawAmount = Convert.ToDecimal(Console.ReadLine());
                            if (withdrawAmount <= 0)
                            {
                                Console.WriteLine("Withdrawal amount must be greater than zero.");
                                continue;
                            }
                            if (withdrawAmount > currentBalance)
                            {
                                Console.WriteLine("Insufficient balance for withdrawal.");
                                continue;
                            }
                            currentBalance -= withdrawAmount;
                            Console.WriteLine($"Successfully withdrawn {withdrawAmount:C}. Current balance: {currentBalance:C}");
                            break;

                        default:
                            Console.WriteLine("Invalid choice. Please try again.");
                            continue;
                    }

                    Console.WriteLine();
                }

                Console.WriteLine("Thank you for using the program!");
            }
        }
    }


