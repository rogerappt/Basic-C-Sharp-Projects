using System;
using System.IO;

namespace NumberLogger
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ask the user for a number
            Console.Write("Enter a number: ");
            string number = Console.ReadLine();

            // Log the number to a text file
            string filePath = "numbers.txt";
            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(number);
            }

            // Print the contents of the text file to the console
            Console.WriteLine("Contents of numbers.txt:");
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
