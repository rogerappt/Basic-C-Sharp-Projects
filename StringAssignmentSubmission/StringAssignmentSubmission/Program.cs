using System;
using System.Text;

namespace StringAssignmentSubmission
{
    class Program
    {
        static void Main(string[] args)
        {
            // Concatenate three strings
            string str1 = "Hello";
            string str2 = " ";
            string str3 = "World";
            string concatenatedString = str1 + str2 + str3;
            Console.WriteLine(concatenatedString);

            // Convert a string to uppercase
            string lowercaseString = "this is a lowercase string";
            string uppercaseString = lowercaseString.ToUpper();
            Console.WriteLine(uppercaseString);

            // Create a StringBuilder and build a paragraph of text, one sentence at a time
            StringBuilder paragraphBuilder = new StringBuilder();
            paragraphBuilder.Append("The quick brown fox ");
            paragraphBuilder.Append("jumps over the lazy dog. ");
            paragraphBuilder.Append("The quick brown fox ");
            paragraphBuilder.Append("jumps over the lazy dog again. ");
            string paragraph = paragraphBuilder.ToString();
            Console.WriteLine(paragraph);
        }
    }
}
