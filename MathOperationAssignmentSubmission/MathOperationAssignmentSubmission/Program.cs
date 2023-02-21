using System;

namespace MathOperationAssignmentSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            // Task 1: Multiply input by 50 and print the result
            Console.Write("Enter a number to multiply by 50: ");
            string inputString = Console.ReadLine();
            if (long.TryParse(inputString, out long input))
            {
                long result = input * 50;
                Console.WriteLine($"Result: {result}");
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }

            // Task 2: Add 25 to input and print the result
            Console.Write("Enter a number to add 25 to: ");
            inputString = Console.ReadLine();
            if (int.TryParse(inputString, out int inputInt))
            {
                int result = inputInt + 25;
                Console.WriteLine($"Result: {result}");
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }

            // Task 3: Divide input by 12.5 and print the result
            Console.Write("Enter a number to divide by 12.5: ");
            inputString = Console.ReadLine();
            if (double.TryParse(inputString, out double inputDouble))
            {
                double result = inputDouble / 12.5;
                Console.WriteLine($"Result: {result}");
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }

            // Task 4: Check if input is greater than 50 and print the result
            Console.Write("Enter a number to check if it's greater than 50: ");
            inputString = Console.ReadLine();
            if (int.TryParse(inputString, out int inputCheck))
            {
                bool result = inputCheck > 50;
                Console.WriteLine($"Result: {result}");
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }

            // Task 5: Divide input by 7 and print the remainder
            Console.Write("Enter a number to divide by 7 and get the remainder: ");
            inputString = Console.ReadLine();
            if (int.TryParse(inputString, out int inputRemainder))
            {
                int result = inputRemainder % 7;
                Console.WriteLine($"Result: {result}");
            }
            else
            {
                Console.WriteLine("Invalid input.");
            }
        }
    }
}
