using System;
using System.Collections.Generic;

namespace List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> primes = new List<int>(new int [] {19, 23, 29});

            foreach (int number in primes) {
                if (number == 23) {
                    Console.WriteLine("Constains 23");
                }
            }

            int index = primes.IndexOf(23);
            Console.WriteLine(index);

            index = primes.IndexOf(10);
            Console.WriteLine(index);

            List<string> cities = new List<string>();
            cities.Add("New York");
            cities.Add("Mumbai");
            cities.Add("Berlin");

            string line = string.Join(",", cities.ToArray());
            Console.WriteLine(line);
        }
    }
}
