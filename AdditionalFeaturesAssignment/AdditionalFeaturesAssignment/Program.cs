using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Create a const variable.
            const int myConstVar = 10;

            // 2. Create a variable using the keyword "var."
            var myVar = "Hello World!";

            // 3. Chain two constructors together.
            var myClass = new MyClass("John", 30);

            Console.WriteLine($"The value of myConstVar is {myConstVar}");
            Console.WriteLine($"The value of myVar is {myVar}");
            Console.WriteLine($"The value of myClass.Name is {myClass.Name} and myClass.Age is {myClass.Age}");
        }
    }

    public class MyClass
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public MyClass(string name) : this(name, 0)
        {
        }

        public MyClass(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
    }
}
