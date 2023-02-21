using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pitman Training");
            Console.WriteLine("Student Daily Report");

            Console.Write("What course are you in? ");
            string courseName = Console.ReadLine();

            Console.Write("What page number? ");
            int pageNumber = int.Parse(Console.ReadLine());

            Console.Write("Do you need help with anything? (true/false) ");
            bool needsHelp = bool.Parse(Console.ReadLine());

            Console.Write("Were there any positive experiences you’d like to share? Please provide specifics. ");
            string positiveExperience = Console.ReadLine();

            Console.Write("Is there any other feedback you’d like to provide? Please be specific. ");
            string feedback = Console.ReadLine();

            Console.Write("How many hours did you study today? ");
            double hoursStudied = double.Parse(Console.ReadLine());

            Console.WriteLine("Thank you for your responses. An Instructor will respond shortly. Have a great day!");
        }
    }
}
