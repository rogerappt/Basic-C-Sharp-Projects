using System;

namespace IncomeComparisonAssignmentSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program\n");

            Console.WriteLine("Person 1");
            Console.Write("Hourly Rate? ");
            double rate1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Hours worked per week? ");
            int hours1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nPerson 2");
            Console.Write("Hourly Rate? ");
            double rate2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Hours worked per week? ");
            int hours2 = Convert.ToInt32(Console.ReadLine());

            double salary1 = rate1 * hours1 * 52;
            double salary2 = rate2 * hours2 * 52;

            Console.WriteLine("\nAnnual salary of Person 1: " + salary1.ToString("C"));
            Console.WriteLine("Annual salary of Person 2: " + salary2.ToString("C"));

            bool person1EarnsMore = salary1 > salary2;
            Console.WriteLine("\nPerson 1 makes more money than Person 2");
            Console.WriteLine(person1EarnsMore);
        }
    }
}
