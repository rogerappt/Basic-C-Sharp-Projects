using System;
using System.Collections.Generic;

namespace ArraysAssignment
{

    class Program
    {
        static void Main(string[] args)
        {
            // Part 1: One-dimensional array of strings
            string[] stringArray = { "apple", "banana", "cherry", "date" };
            Console.Write("Enter an index for the string array (0-3): ");
            int stringIndex = int.Parse(Console.ReadLine());
            if (stringIndex >= 0 && stringIndex < stringArray.Length)
            {
                Console.WriteLine("The string at index {0} is {1}", stringIndex, stringArray[stringIndex]);
            }
            else
            {
                Console.WriteLine("The index {0} is out of range for the string array", stringIndex);
            }

            // Part 2: One-dimensional array of integers
            int[] intArray = { 10, 20, 30, 40 };
            Console.Write("Enter an index for the integer array (0-3): ");
            int intIndex = int.Parse(Console.ReadLine());
            if (intIndex >= 0 && intIndex < intArray.Length)
            {
                Console.WriteLine("The integer at index {0} is {1}", intIndex, intArray[intIndex]);
            }
            else
            {
                Console.WriteLine("The index {0} is out of range for the integer array", intIndex);
            }

            // Part 3: Display message when index is out of range
            List<string> stringList = new List<string> { "Alice", "Bob", "Charlie", "Dave" };
            Console.Write("Enter an index for the string list (0-3): ");
            int listIndex = int.Parse(Console.ReadLine());
            if (listIndex >= 0 && listIndex < stringList.Count)
            {
                Console.WriteLine("The string at index {0} is {1}", listIndex, stringList[listIndex]);
            }
            else
            {
                Console.WriteLine("The index {0} is out of range for the string list", listIndex);
            }

            // Part 4: List of strings
            Console.Write("Enter an index for the string list (0-3): ");
            int listIndex2 = int.Parse(Console.ReadLine());
            if (listIndex2 >= 0 && listIndex2 < stringList.Count)
            {
                Console.WriteLine("The string at index {0} is {1}", listIndex2, stringList[listIndex2]);
            }
            else
            {
                Console.WriteLine("The index {0} is out of range for the string list", listIndex2);
            }
        }
    }
}