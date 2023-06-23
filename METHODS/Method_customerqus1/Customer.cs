using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_customerqus1
{
    internal class Customer
    {



        private int _id;
        private string _name;
        private string _email;
        private string _address;
        private string _purpose;
        private string _otherDetails;


        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Email
        {
            get { return _email; }
            set { _email = value; }
        }
        public string Address
        {
            get { return _address; }
            set { _address = value; }
        }


        public string Purpose
        {
            get { return _purpose; }
            set { _purpose = value; }
        }


        public string OtherDetails
        {
            get { return _otherDetails; }
            set { _otherDetails = value; }
        }

        public void Display()
        {
            Console.WriteLine("Customer details are :");
            Console.WriteLine("ID :" + Convert.ToString(this.Id));
            Console.WriteLine("Name :" + this.Name);
            Console.WriteLine("Email :" + this.Email);
            Console.WriteLine("Address :" + this.Address);
            Console.WriteLine("Purpose :" + this.Purpose);
            Console.WriteLine("Other details :" + this.OtherDetails);
        }
    }
}

