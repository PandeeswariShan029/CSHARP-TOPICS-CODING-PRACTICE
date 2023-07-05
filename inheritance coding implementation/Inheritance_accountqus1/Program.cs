using System.ComponentModel.DataAnnotations;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;

namespace Inheritance_accountqus1
{
    internal class Program
    {
        public class Account
        {
            protected string _holderName;
            protected long _accountNumber;
            protected string _IFSCCode;
            protected long _contactNumber;
            public string HolderName
            {
                get { return _holderName; }
                set { _holderName = value; }
            }
            public long AccountNumber
            {
                get { return _accountNumber; }
                set { _accountNumber = value; }
            }
            public string IFSCCode
            {
                get { return _IFSCCode; }
                set
                {
                    _IFSCCode = value;
                }
            }
            public long ContactNumber
            {
                get { return _contactNumber; }
                set { _contactNumber = value; }

            }

            public Account()
            {

            }
            public Account(string holdername, long accountnumber, string IFSCCode, long contactNumber)
            {
                _holderName = holdername;
                _accountNumber = accountnumber;
                _IFSCCode = IFSCCode;
                _contactNumber = contactNumber;

            }
            public virtual void Display()
            {
                Console.WriteLine("Your Contact Details:");
                Console.WriteLine("HolderName:" + HolderName);
                Console.WriteLine("Account Number:" + AccountNumber);
                Console.WriteLine("IFSCCode:" + IFSCCode);
                Console.WriteLine("ContactNumber:" + ContactNumber);
            }
        }
        public class CurrentAccount : Account
        {
            private string _organizationName;
            private long _TIN;
            public string OrganizationName
            {
                get { return _organizationName; }
                set { _organizationName = value; }
            }
            public long TIN
            {
                get { return _TIN; }
                set { _TIN = value; }
            }
            public CurrentAccount(string holdername, long accountnumber, string IFSCCode, long contactNumber, string organizationname, long tin)  base(holdername, accountnumber, IFSCCode, contactNumber)
            {
                _holderName = holdername;
                _accountNumber = accountnumber;
                _IFSCCode = IFSCCode;
                _contactNumber = contactNumber;
                _organizationName = organizationname;
                _TIN = tin;
            }
            public override void Display()
            {
                base.Display();
                Console.WriteLine("OrganizationName:" + OrganizationName);
                Console.WriteLine("TIN:" + TIN);

            }
        }
        public class SavingAccount : Account
        {
            private double _interestRate;
            public double InterestRate
            {
                get { return _interestRate; }
                set { _interestRate = value; }
            }
            public SavingAccount(string holdername, long accountnumber, string IFSCCode, long contactNumber, double interest) : base(holdername, accountnumber, IFSCCode, contactNumber)

            {
                _holderName = holdername;
                _accountNumber = accountnumber;
                _IFSCCode = IFSCCode;
                _contactNumber = contactNumber;
                _interestRate = interest;

            }
            public override void Display()
            {

                base.Display();
                Console.WriteLine("Interestrate:" + InterestRate);
            }
        }
    


        static void Main(string[] args)
        {
            Console.WriteLine("Enter User Details");
            Console.WriteLine("Enter holder name");
            string holder = Console.ReadLine();
            Console.WriteLine("Enter acc number");
            long acc = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter ifsc");
            string ifsc = Console.ReadLine();
            Console.WriteLine("Enter contact num");
            long contact = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter account type(saving/current)");
            string accounttype = Console.ReadLine();
            switch(accounttype)
            {
                case "saving":
                    Console.WriteLine("Enter Interest Rate:");
                    double interestrate = Convert.ToDouble(Console.ReadLine());
                    SavingAccount s = new SavingAccount(holder, acc, ifsc, contact,interestrate);   
                    s.Display();
                    break;
                case "current":
                    Console.WriteLine("Enter Organization Name:");
                    string oname = Console.ReadLine();
                    Console.WriteLine("Enter TIN number:");
                    long tin = Convert.ToInt64(Console.ReadLine());
                    CurrentAccount c = new CurrentAccount(holder, acc, ifsc, contact, oname, tin);
                    c.Display();

                    break;
                    default:
                    Console.WriteLine("Invalid account type");
                    break;
                    
            }


        }
    }
}


