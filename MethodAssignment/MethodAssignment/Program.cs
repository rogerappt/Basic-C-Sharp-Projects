using System;

namespace MethodAssignment
{
    class MathOperations
    {
        public int Add(int num)
        {
            return num + 5;
        }

        public int Subtract(int num)
        {
            return num - 3;
        }

        public int Multiply(int num)
        {
            return num * 2;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to perform math operations on:");
            int num = int.Parse(Console.ReadLine());

            MathOperations mathOps = new MathOperations();

            int result1 = mathOps.Add(num);
            Console.WriteLine($"Result of adding 5 to {num} is {result1}");

            int result2 = mathOps.Subtract(num);
            Console.WriteLine($"Result of subtracting 3 from {num} is {result2}");

            int result3 = mathOps.Multiply(num);
            Console.WriteLine($"Result of multiplying {num} by 2 is {result3}");

            Console.ReadLine();
        }
    }
}
