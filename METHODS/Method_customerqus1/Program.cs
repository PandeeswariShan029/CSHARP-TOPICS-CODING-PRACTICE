namespace Method_customerqus1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer c = new Customer();

            Console.WriteLine("Enter the customer details");
            Console.WriteLine("Enter the  id :");
            c.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the name :");
            c.Name = Console.ReadLine();
            Console.WriteLine("Enter the email :");
            c.Email = Console.ReadLine();
            Console.WriteLine("Enter the address :");
            c.Address = Console.ReadLine();
            Console.WriteLine("Enter the purpose :");
            c.Purpose = Console.ReadLine();
            Console.WriteLine("Enter the other customer details :");
            c.OtherDetails = Console.ReadLine();

            c.Display();
        }
    }
}