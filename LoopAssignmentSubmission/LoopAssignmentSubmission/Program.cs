using System;

namespace LoopAssignmentSubmission
{
    class Program
    {
        static void Main()
        {
            // Example using a while statement
            int i = 0;
            while (i < 5)
            {
                Console.WriteLine("While loop iteration: {0}", i);
                i++;
            }

            // Example using a do while statement
            int j = 0;
            do
            {
                Console.WriteLine("Do while loop iteration: {0}", j);
                j++;
            } while (j < 5);

            Console.ReadLine();
        }
    }
}
