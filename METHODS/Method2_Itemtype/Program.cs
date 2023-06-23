namespace Method2_Itemtype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ItemType itemType = new ItemType(); 
            Customer customer = new Customer();
            Console.WriteLine("Enter the item type name:");
            itemType.name = Console.ReadLine();
            Console.WriteLine("Enter the cost per day:");
            itemType.cost = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the deposit:");
            itemType.depo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter the customer ID:");
            customer.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the customer name");
            customer.Name = Console.ReadLine();
            Console.WriteLine("Enter the customer email:");
            customer.Email = Console.ReadLine();
            Console.WriteLine("Enter the customer address");
            customer.Address = Console.ReadLine();
            Console.WriteLine("Enter the purpose");
            customer.Purpose = Console.ReadLine();
            Console.WriteLine("Enter any other details");
            customer.Otherdetails = Console.ReadLine();
            itemType.Display();
            customer.Display();
            

        }
    }
}