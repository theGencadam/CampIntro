using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager1 = new CustomerManager();
            Customer customer1 = new Customer();
            Customer customer2 = new Customer();
            Customer customer3 = new Customer();

            customer1.Adi = "Bilal";
            customer1.Soyadi = "Kalkan";
            customer1.Yas = 22;
            customer1.Id = 99;

            customerManager1.Add(customer1);
            customerManager1.Update(customer2);
            customerManager1.Delete(customer3);



            Console.WriteLine(customer1.Adi);
            Console.WriteLine(customer1.Soyadi);
            Console.WriteLine(customer1.Id);
            Console.WriteLine(customer1.Yas);
        }
    }
}
