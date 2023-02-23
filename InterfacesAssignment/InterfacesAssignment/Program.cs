using System;

namespace ConsoleApp
{
    interface IQuittable
    {
        void Quit();
    }

    class Employee : IQuittable
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int EmployeeId { get; set; }

        // Implementation of the Quit method from the IQuittable interface
        public void Quit()
        {
            Console.WriteLine($"{FirstName} {LastName} with Employee ID {EmployeeId} has quit.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an object of type Employee and call the Quit method on it
            Employee employee = new Employee()
            {
                FirstName = "John",
                LastName = "Doe",
                EmployeeId = 12345
            };
            employee.Quit();

            // Create an object of type IQuittable and call the Quit method on it using polymorphism
            IQuittable quittable = new Employee()
            {
                FirstName = "Jane",
                LastName = "Doe",
                EmployeeId = 67890
            };
            quittable.Quit();

            Console.ReadLine();
        }
    }
}
