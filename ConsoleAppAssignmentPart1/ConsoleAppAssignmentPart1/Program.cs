using System;

namespace ConsoleAppAssignmentPart1
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] words = { "apple", "banana", "cherry" };
            Console.Write("Enter some text: ");
            string userInput = Console.ReadLine();

            for (int i = 0; i < words.Length; i++)
            {
                words[i] += userInput;
            }

            Console.WriteLine("Resulting strings:");
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
