using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method2_Itemtype
{
    internal class ItemType
    {
        private string Name;
        private double costPerDay;
        private double deposit;
        public string name
        {
            get { return Name; }
            set { Name = value; }
        
        }
        public double cost
        {
            get { return costPerDay; }
            set { costPerDay = value; }
        }
        public double depo
        {
            get { return deposit; }
            set
            {
                deposit = value;
            }
        }
        public void Display()
        {
            Console.WriteLine("Item type details are:");
            Console.WriteLine("Name:"+"["+name+"]");
            Console.WriteLine("Cost per day:"+"["+cost+"]");
            Console.WriteLine("Deposit:"+"["+depo+"]");
        }
    }
}
