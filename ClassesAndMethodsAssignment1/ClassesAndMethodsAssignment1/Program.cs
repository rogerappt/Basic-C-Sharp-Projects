using System;

namespace ClassesAndMethodsAssignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the class
            MathOperations mathOps = new MathOperations();

            // Call the first method with an integer argument
            int result1 = mathOps.PerformMathOperation(10);
            Console.WriteLine("Result of integer math operation: " + result1);

            // Call the second method with a decimal argument
            int result2 = mathOps.PerformMathOperation(10.5m);
            Console.WriteLine("Result of decimal math operation: " + result2);

            // Call the third method with a string argument
            int result3 = mathOps.PerformMathOperation("20");
            Console.WriteLine("Result of string math operation: " + result3);
        }
    }

    class MathOperations
    {
        public int PerformMathOperation(int num)
        {
            // Perform a math operation on the integer
            int result = num * 2;

            // Return the result
            return result;
        }

        public int PerformMathOperation(decimal num)
        {
            // Perform a different math operation on the decimal
            int result = (int)Math.Round(num * 3, 0);

            // Return the result
            return result;
        }

        public int PerformMathOperation(string str)
        {
            // Convert the string to an integer if possible
            int num;
            bool isNumeric = int.TryParse(str, out num);

            // If conversion was successful, perform a different math operation
            if (isNumeric)
            {
                int result = num + 5;

                // Return the result
                return result;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid integer.");
                return 0;
            }
        }
    }
}
