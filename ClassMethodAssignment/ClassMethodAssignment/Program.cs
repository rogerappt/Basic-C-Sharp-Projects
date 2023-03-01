using System;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the class
            MyClass myClass = new MyClass();

            // Prompt the user to enter a number
            Console.WriteLine("Enter a number: ");
            int input = int.Parse(Console.ReadLine());

            // Call the method on the entered number
           myClass.DivideByTwo(input);


            // Call the method with output parameters
            int output1, output2;
            myClass.MethodWithOutputParams(input, out output1, out output2);
            Console.WriteLine($"The outputs of the method with output parameters are: {output1}, {output2}");

            // Call the overloaded method
            myClass.OverloadedMethod();
            myClass.OverloadedMethod("This is an overloaded method");

            // Declare a static class
            StaticClass.Method();
        }
    }

    // Step 1: Create a class with a void method that outputs an integer
    class MyClass
    {
        public void DivideByTwo(int number)
        {
            Console.WriteLine(number / 2);
        }

        // Step 4: Method with output parameters
        public void MethodWithOutputParams(int input, out int output1, out int output2)
        {
            output1 = input * 2;
            output2 = input * 3;
        }

        // Step 5: Overloaded method
        public void OverloadedMethod()
        {
            Console.WriteLine("This is the original method");
        }

        public void OverloadedMethod(string message)
        {
            Console.WriteLine(message);
        }
    }

    // Step 6: Declare a static class
    static class StaticClass
    {
        public static void Method()
        {
            Console.WriteLine("This is a static class method");
        }
    }
}
