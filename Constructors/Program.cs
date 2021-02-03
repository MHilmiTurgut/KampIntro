using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {

            Customer customer = new Customer { Id = 170, FirstName ="Hilmi", LastName = "Turgut" };
            Console.WriteLine(customer.Id);
            Console.WriteLine(customer.FirstName);
            Console.WriteLine(customer.LastName);
        }

    }

    class Customer
    {
        public Customer()
        {
            Console.WriteLine("Yapıcı blok çalıştı!!!");
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }


    }
}
