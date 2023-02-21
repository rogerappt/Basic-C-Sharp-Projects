using System;

namespace BooleanLogicAssignmentSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Have you ever had a DUI violation? (true/false)");
            bool hasDui = bool.Parse(Console.ReadLine());

            Console.WriteLine("How many speeding tickets do you have?");
            int numTickets = int.Parse(Console.ReadLine());

            bool isQualified = (age > 15) && (!hasDui) && (numTickets <= 3);

            Console.WriteLine("Qualified? " + isQualified);
        }
    }
}
