using System;

namespace EmployeeComparison
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public static bool operator ==(Employee employee1, Employee employee2)
        {
            if (ReferenceEquals(employee1, employee2))
            {
                return true;
            }

            if (employee1 is null || employee2 is null)
            {
                return false;
            }

            return employee1.Id == employee2.Id;
        }

        public static bool operator !=(Employee employee1, Employee employee2)
        {
            return !(employee1 == employee2);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee employee1 = new Employee { Id = 1, Name = "John" };
            Employee employee2 = new Employee { Id = 2, Name = "Jane" };
            Employee employee3 = new Employee { Id = 1, Name = "Jack" };

            Console.WriteLine(employee1 == employee2); // false
            Console.WriteLine(employee1 == employee3); // true
            Console.WriteLine(employee2 == null); // false
            Console.WriteLine(employee1 == null); // false
            Console.WriteLine(null == null); // true
        }
    }
}
