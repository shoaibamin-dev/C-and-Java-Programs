using System;

namespace FindLargestNumberApp
{

    /* Input 10 integers
     * Calculate largest int
     * Display output
     * 
     * Use: counter
     * 
     * Pseudocode
     * 
     * loop 10 times
     * input number from user
     * if input is > largest number
     * set input as new largest number
     * loop
     * 
     * Output largest number
     * 
     */
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables
            int input = 0, largest = 0;

            for (int i = 1; i <= 10; i ++)
            {
                // Input number
                Console.Write("Enter number: ");
                input = int.Parse(Console.ReadLine());

                // If input is larger, set as new largest
                if (input > largest)
                {
                    largest = input;
                }
            }

            // Output largest number
            Console.WriteLine($"The largest number is {largest}");
        }
    }
}
