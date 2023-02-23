using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Employee<T>
    {
        public List<T> Things { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee<string> employee1 = new Employee<string>();
            employee1.Things = new List<string> { "apple", "banana", "orange" };

            Employee<int> employee2 = new Employee<int>();
            employee2.Things = new List<int> { 1, 2, 3, 4, 5 };

            Console.WriteLine("Employee 1 Things:");
            foreach (string thing in employee1.Things)
            {
                Console.WriteLine(thing);
            }

            Console.WriteLine("Employee 2 Things:");
            foreach (int thing in employee2.Things)
            {
                Console.WriteLine(thing);
            }

            Console.ReadLine();
        }
    }
}
