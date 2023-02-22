using System;

class MathOperations
{
    public int PerformOperation(int num1, int num2 = 0)
    {
        // if num2 is not provided, use 0 as default value
        return num1 + num2;
    }
}

class Program
{
    static void Main(string[] args)
    {
        MathOperations math = new MathOperations();

        Console.Write("Enter the first number: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter the second number (optional): ");
        string input = Console.ReadLine();
        int num2 = 0; // set default value to 0
        if (!string.IsNullOrEmpty(input))
        {
            num2 = int.Parse(input);
        }

        int result = math.PerformOperation(num1, num2);
        Console.WriteLine($"Result: {result}");

        // try with different combinations of numbers
        Console.WriteLine("\nTrying different combinations:");
        Console.WriteLine($"Result: {math.PerformOperation(2, 3)}"); // 5
        Console.WriteLine($"Result: {math.PerformOperation(10)}"); // 10
        Console.WriteLine($"Result: {math.PerformOperation(5, 7)}"); // 12

        Console.ReadKey();
    }
}
