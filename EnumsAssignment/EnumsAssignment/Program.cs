using System;

namespace ConsoleApp
{
    class Program
    {
        enum DaysOfWeek { Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday }

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter the current day of the week:");
                string userInput = Console.ReadLine();

                DaysOfWeek currentDay = (DaysOfWeek)Enum.Parse(typeof(DaysOfWeek), userInput);

                Console.WriteLine("Today is " + currentDay.ToString());
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Please enter an actual day of the week.");
            }
        }
    }
}
