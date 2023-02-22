using System;
using System.Collections.Generic;

namespace ExceptionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 10, 20, 30, 40, 50 };

            try
            {
                Console.Write("Enter a number to divide each number in the list by: ");
                int divisor = int.Parse(Console.ReadLine());

                foreach (int number in numbers)
                {
                    double result = number / divisor;
                    Console.WriteLine("{0} divided by {1} is {2}", number, divisor, result);
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Error: Cannot divide by zero.");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error: Invalid input. Please enter a valid integer.");
            }
            finally
            {
                Console.WriteLine("Program execution continued.");
            }

            Console.ReadKey();
        }
    }
}
