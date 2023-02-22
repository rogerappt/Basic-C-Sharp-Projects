using System;

namespace MathOperations
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the class
            MathOperations mathOps = new MathOperations();

            // Call the method in the class, passing in two numbers
            mathOps.DoMathOperation(10, 5);

            // Call the method in the class, specifying the parameters by name
            mathOps.DoMathOperation(firstNumber: 15, secondNumber: 7);

            Console.ReadLine();
        }
    }

    class MathOperations
    {
        public void DoMathOperation(int firstNumber, int secondNumber)
        {
            // Perform a math operation on the first integer
            int result = firstNumber * 2;

            // Display the second integer to the screen
            Console.WriteLine($"The second integer is: {secondNumber}");
        }
    }
}
