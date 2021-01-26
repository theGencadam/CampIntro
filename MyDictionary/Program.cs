using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<int, string> personals = new Dictionary<int, string>();
            personals.Add(1, "Bilal");
            personals.Add(2, "Fırat");
            personals.Add(3, "Ali");

            Console.WriteLine(personals.Count);
        }
    }
}
