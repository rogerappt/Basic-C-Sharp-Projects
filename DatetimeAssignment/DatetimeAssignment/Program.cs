using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Step 1: Print current date and time to console
            Console.WriteLine("Current date and time: " + DateTime.Now);

            // Step 2: Ask user for a number
            Console.Write("Enter a number: ");
            int hours = int.Parse(Console.ReadLine());

            // Step 3: Calculate and print time after X hours
            DateTime futureTime = DateTime.Now.AddHours(hours);
            Console.WriteLine("The time after " + hours + " hours will be: " + futureTime);

            // Wait for user to press any key before closing console
            Console.ReadKey();
        }
    }
}
