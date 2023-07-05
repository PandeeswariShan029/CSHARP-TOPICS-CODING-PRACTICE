

/*Question: Implement a Bank Account System

You have been tasked with implementing a bank account system using object-oriented programming concepts in C#. The system should have classes to represent different types of accounts and a class to manage account operations. Your task is to complete the given code to make it work correctly.

Class Definitions:

Account class:

Properties:
AccountNumber (string): The account number.
Balance (double): The current balance in the account.
AccountHolderName (string): The name of the account holder.
Constructor:
Initializes the AccountNumber, Balance, and AccountHolderName properties with the provided values.

SavingAccount class (inherits from Account):

Properties:
MinimumBalance (double): The minimum balance required in the account.
Constructor:
Initializes the AccountNumber, Balance, AccountHolderName, and MinimumBalance properties with the provided values.


FixedAccount class (inherits from SavingAccount):

Properties:
LockingPeriod (int): The locking period in months for the fixed account.
Constructor:
Initializes the AccountNumber, Balance, AccountHolderName, MinimumBalance, and LockingPeriod properties with the provided values.



AccountBO class:

Methods:
CreateAccountDetail(string details): This method takes a string containing comma-separated account details and returns a FixedAccount object created with the provided details. The account details are in the following order: AccountNumber, Balance, AccountHolderName, MinimumBalance, LockingPeriod.

DisplayAccountDetails(List<FixedAccount> fixedAccountList): This method takes a list of FixedAccount objects and displays the account details in a tabular format. The table should include the following columns: "Account Number", "Balance", "Account holder name", "Minimum balance", "Locking period".
Instructions:

Complete the implementation of the Account, SavingAccount, and FixedAccount classes according to the provided constructors and properties.
Implement the CreateAccountDetail method in the AccountBO class to create a FixedAccount object based on the provided account details.
Implement the DisplayAccountDetails method in the AccountBO class to display the account details in a tabular format as specified.
In the Main method, prompt the user to enter the number of accounts to create.
Inside a loop, prompt the user to enter the details for each account and use the CreateAccountDetail method to create a FixedAccount object. Add each created object to the fixedAccountList.
Finally, call the DisplayAccountDetails method to display the account details in a tabular format 

Sample Input:
Enter the number of accounts:
3
Enter account-1 Detail:
001, 5000, John Doe, 1000, 12
Enter account-2 Detail:
002, 10000, Jane Smith, 2000, 24
Enter account-3 Detail:
003, 2000, David Johnson, 500, 6





Sample Output:
Account Number       Balance   Account holder name  Minimum balance  Locking period
001                  5000.0    John Doe             1000.0           12
002                  10000. */

using System;

namespace Inheritance_accountsqus4
{
    internal class Program
    {
        public class Account
        {
            public string AccountNumber;
            public double Balance;
            public string AccountholderName;
            public Account(string accn, double b, string acchname)
            {
                AccountNumber = accn;
                Balance = b;
                AccountholderName = acchname;
            }
        }
            public class SavingAccount:Account
            {
               public  double MinimumBalance;
                public SavingAccount(string accn, double b, string acchname,double minimumBalance):base( accn,  b,  acchname)
                {
                    MinimumBalance = minimumBalance;
                }

            }
            public class FixedAccount : SavingAccount
            {
                public int LockingPeriod;
                public FixedAccount(string accn, double b, string acchname, double minimumBalance, int lp):base(accn, b, acchname,minimumBalance)
                {
                    LockingPeriod = lp;
                }
            }

            public class AccountBO
            {
                public FixedAccount CreateAccountDetails(string details)
                {
                    string[] data = details.Split(",");
                    string acno = data[0];
                    int bal = Convert.ToInt32(data[1]);
                    string acholdername = data[2];
                    double minbal = Convert.ToDouble(data[3]);
                    int lperiod = Convert.ToInt32(data[4]);
                    FixedAccount fa = new FixedAccount(acno, bal, acholdername, minbal, lperiod);
                    return fa;
                    
                }
                public void DisplayAccountDetails(List<FixedAccount> Accountlist)
                {
                Console.WriteLine("{0,-20} {1,-10} {2,-20} {3,-20} {4}", "Account Number", "Balance", "Account holder name", "Minimum balance", "Locking period");

                foreach (FixedAccount ac in Accountlist)
                    {
                        Console.WriteLine("{0,-20}{1,-10}{2,-20}{3,-20}{4}", ac.AccountNumber, ac.Balance, ac.AccountholderName, ac.MinimumBalance,ac.LockingPeriod);
                    }
                }
            }

        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of accounts");
            int n = Convert.ToInt32(Console.ReadLine());
            AccountBO ac = new AccountBO();
            List<FixedAccount> fcacclist = new List<FixedAccount>();  
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"Enter account-{i + 1} Detail :");
                string de = Console.ReadLine();
                fcacclist.Add(ac.CreateAccountDetails(de));

            }

            ac.DisplayAccountDetails(fcacclist);
        }
    }
}
