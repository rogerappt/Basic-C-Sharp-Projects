using System;

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public void SayName()
    {
        Console.WriteLine($"Name: {FirstName} {LastName}");
    }
}

public class Employee : Person
{
    public int Id { get; set; }
}

class Program
{
    static void Main(string[] args)
    {
        Employee employee = new Employee
        {
            FirstName = "Sample",
            LastName = "Student",
            Id = 1234
        };

        employee.SayName();
    }
}
