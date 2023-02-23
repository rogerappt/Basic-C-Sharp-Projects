using System;

struct Number
{
    public decimal Amount { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        Number myNumber = new Number { Amount = 123.45M };
        Console.WriteLine("Amount: {0}", myNumber.Amount);
        Console.ReadKey();
    }
}
