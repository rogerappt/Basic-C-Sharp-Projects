using System;

namespace PersonExample
{
    abstract class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        public abstract void SayName();
    }

    class Employee : Person
    {
        public override void SayName()
        {
            Console.WriteLine($"My name is {firstName} {lastName}.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee employee = new Employee()
            {
                firstName = "Sample",
                lastName = "Student"
            };

            employee.SayName();

            Console.ReadKey();
        }
    }
}
