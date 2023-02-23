using System;
using System.Collections.Generic;
using System.Linq;

namespace EmployeeList
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of employees
            var employees = new List<Employee>
            {
                new Employee { Id = 1, FirstName = "John", LastName = "Doe" },
                new Employee { Id = 2, FirstName = "Jane", LastName = "Doe" },
                new Employee { Id = 3, FirstName = "Bob", LastName = "Smith" },
                new Employee { Id = 4, FirstName = "Joe", LastName = "Johnson" },
                new Employee { Id = 5, FirstName = "Mary", LastName = "Johnson" },
                new Employee { Id = 6, FirstName = "Joe", LastName = "Brown" },
                new Employee { Id = 7, FirstName = "Tom", LastName = "Jones" },
                new Employee { Id = 8, FirstName = "Sara", LastName = "Lee" },
                new Employee { Id = 9, FirstName = "Mike", LastName = "Jones" },
                new Employee { Id = 10, FirstName = "Amy", LastName = "Smith" }
            };

            // Create a new list of employees with the first name "Joe" using a foreach loop
            var joes = new List<Employee>();
            foreach (var employee in employees)
            {
                if (employee.FirstName == "Joe")
                {
                    joes.Add(employee);
                }
            }

            // Print the list of Joes
            Console.WriteLine("List of employees with the first name \"Joe\" (using a foreach loop):");
            foreach (var joe in joes)
            {
                Console.WriteLine($"Id: {joe.Id}, Name: {joe.FirstName} {joe.LastName}");
            }

            // Create a new list of employees with the first name "Joe" using a lambda expression
            joes = employees.Where(e => e.FirstName == "Joe").ToList();

            // Print the list of Joes
            Console.WriteLine("\nList of employees with the first name \"Joe\" (using a lambda expression):");
            foreach (var joe in joes)
            {
                Console.WriteLine($"Id: {joe.Id}, Name: {joe.FirstName} {joe.LastName}");
            }

            // Create a new list of employees with an Id number greater than 5 using a lambda expression
            var highIds = employees.Where(e => e.Id > 5).ToList();

            // Print the list of employees with high Ids
            Console.WriteLine("\nList of employees with an Id number greater than 5:");
            foreach (var employee in highIds)
            {
                Console.WriteLine($"Id: {employee.Id}, Name: {employee.FirstName} {employee.LastName}");
            }

            Console.ReadKey();
        }
    }

    class Employee
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
