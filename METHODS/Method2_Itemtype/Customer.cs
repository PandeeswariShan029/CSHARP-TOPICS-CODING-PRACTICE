using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method2_Itemtype
{
    internal class Customer
    {
        private int id;
        private string name;
        private string email;
        private string address;
        private string purpose;
        private string otherdetails;
        public int Id 
        { 
            get { return id; }
            set {  id = value; }
        }
        public string Name
        { 
            get { return name; } 
            set {  name = value; }
        }
        public string Email
        {
            get { return email; }
            set
            {
                email = value;
            }
        }
        public string Address
        {
            get { return address; }
            set
            {
                address = value;
            }
        }
        public string Purpose
        {
            get { return purpose; }
            set
            {
                purpose = value;
            }
        }
        public string Otherdetails
        {
            get { return otherdetails; }
            set
            {
                otherdetails = value;
            }
        }
        public void Display()
        {
            Console.WriteLine("Customer details are:");
            Console.WriteLine("ID:" + Id);
            Console.WriteLine("Name:" + Name);
            Console.WriteLine("Email:" + Email);
            Console.WriteLine("Address:" + Address);
            Console.WriteLine("Purpose:" + Purpose);
            Console.WriteLine("Other Details:" + Otherdetails);
        }



    }
}
