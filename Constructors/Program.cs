using System;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer() { Id = 1, FirstName = "Bilal", LastName = "Kalkan", City = "İstanbul" };
            Customer customer3 = new Customer();

            customer3.Id = 3;
            customer3.FirstName = "Engin";
            customer3.LastName = "Demiroğ";
            customer3.City = "İstanbul";

            Customer customer2 = new Customer(1, "Fırat", "Kalkan", "İstanbul");
            Console.WriteLine(customer2.FirstName);
        }
    }

    class Customer
    {

        public Customer()
        {

        }
        public Customer(int ıd, string firstName, string lastName, string city)
        {
            Id = ıd;
            FirstName = firstName;
            LastName = lastName;
            City = city;


        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }
    }
    
}
