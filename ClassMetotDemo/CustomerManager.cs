using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Added!!");
        }

        public void Update(Customer customer)
        {
            Console.WriteLine("Updated!!");
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("Deleted!!");
        }
    }
}
