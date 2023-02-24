using System;
using System.Collections.Generic;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //1. One-dimensional array of strings
            string[] arr = { "Hello", "World", "I", "love", "C#" };

            //2. Ask the user to input some text
            Console.WriteLine("Enter some text:");
            string userInput = Console.ReadLine();

            //3. Loop that iterates through each string in the array and adds the user's text input to the end of each string
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] += " " + userInput;
            }

            //4. Loop that prints off each string in the array on a separate line
            foreach (string str in arr)
            {
                Console.WriteLine(str);
            }

            //5. Infinite loop
            while (true)
            {
                //6. Fixed the infinite loop by adding a break statement
                Console.WriteLine("Press any key to continue, or 'q' to quit.");
                if (Console.ReadLine() == "q")
                    break;
            }

            //7. Loop using "<" operator
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            //8. Saved and executed code

            //9. Loop using "<=" operator
            for (int i = 0; i <= arr.Length - 1; i++)
            {
                Console.WriteLine(arr[i]);
            }

            //10. List of unique strings
            List<string> list = new List<string> { "apple", "banana", "orange", "grape", "peach" };

            //11. Ask user to input text to search for in the list
            Console.WriteLine("Enter text to search for:");
            string searchInput = Console.ReadLine();

            //12. Loop that iterates through the list and displays the index of the list that contains matching text on the screen
            bool matchFound = false;
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i] == searchInput)
                {
                    Console.WriteLine("Match found at index " + i);
                    matchFound = true;
                    //13. Tells user if they put in text that isn’t in the list
                    break;
                }
            }
            if (!matchFound)
            {
                Console.WriteLine("No match found.");
            }

            //14. Stops loop from executing once a match has been found

            //15. List of strings with at least two identical strings, ask user to select text to search for in the list
            List<string> listWithDuplicates = new List<string> { "apple", "banana", "orange", "grape", "peach", "banana" };
            Console.WriteLine("Enter text to search for:");
            string searchInputWithDuplicates = Console.ReadLine();

            //16. Loop that iterates through the list and displays the indices of the list that contain matching text on the screen
            matchFound = false;
            for (int i = 0; i < listWithDuplicates.Count; i++)
            {
                if (listWithDuplicates[i] == searchInputWithDuplicates)
                {
                    Console.WriteLine("Match found at index " + i);
                    matchFound = true;
                }
            }
            if (!matchFound)
            {
                Console.WriteLine("No match found.");
            }

            //17. Tells user if they put in text that isn’t in the list
            //18. List of strings with at least two identical strings