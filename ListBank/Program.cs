using System;
using System.Collections.Generic;

namespace ListBank
{
    internal class Program
    {
        class BankAccount
        {
            public string CustomerName { get; set; }
            public int AccountNumber { get; set; }
            public double Balance { get; set; }



            public void Deposit(double amount)
            {
                Balance += amount;
            }

            public void Withdraw(double amount)
            {
                if (Balance >= amount)
                {
                    Balance -= amount;
                }
                else
                {
                    Console.WriteLine("Insufficient balance for withdrawal.");
                }
            }

            public void Show()
            {
                Console.WriteLine("Customer Account Information");
                Console.WriteLine("Account Number: " + AccountNumber);
                Console.WriteLine("Customer Name: " + CustomerName);
                Console.WriteLine("Balance: " + Balance);
            }
        }


        static void Main(string[] args)
        {
            List<BankAccount> accounts = new List<BankAccount>();
            BankAccount b = new BankAccount();
            Console.WriteLine("Enter no.of customers details to be updated and displayed");
            int n = Convert.ToInt32(Console.ReadLine());
            
               
            for(int i=0;i<n;i++) {
                Console.WriteLine("1.Add customer details and display");
                Console.WriteLine("2.exit");
                
                
            
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Please enter your name:");
                        b.CustomerName = Console.ReadLine();

                        Console.WriteLine("Please enter your account number:");
                        b. AccountNumber = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Please enter your initial deposit:");
                        b.Balance = Convert.ToDouble(Console.ReadLine());

                        accounts.Add(b);
                        Console.WriteLine("Please enter the amount to deposit:");
                        double depositAmount = Convert.ToDouble(Console.ReadLine());

                        b.Deposit(depositAmount);
                        Console.WriteLine("Please enter the amount to withdraw:");
                        double withdrawAmount = Convert.ToDouble(Console.ReadLine());
                        b.Withdraw(withdrawAmount);
                        b.Show();

                        break;
                    case 2:
                        Console.WriteLine("Thanks for coming!!!! visit again!!!..");
                        return;
                    default:
                        Console.WriteLine("Enter valid choice");
                        break;
                       


                }

            }
        }
    }
}

