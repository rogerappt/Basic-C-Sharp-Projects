using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter your age: ");
                int age = int.Parse(Console.ReadLine());
                if (age <= 0)
                {
                    throw new Exception("Age cannot be zero or negative.");
                }
                int birthYear = DateTime.Now.Year - age;
                Console.WriteLine("You were born in " + birthYear + ".");
            }
            catch (FormatException)
            {
                Console.WriteLine("Invalid age format.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Press any key to exit.");
                Console.ReadKey();
            }
        }
    }
}
