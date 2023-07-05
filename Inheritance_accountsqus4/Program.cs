using System.Security.Cryptography.X509Certificates;

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