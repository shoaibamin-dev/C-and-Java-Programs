using System;

namespace CountingApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int value = 0, posCount = 0, negCount = 0, zeroCount = 0;
            for (int i = 1; i <=5; i++)
            {
                Console.Write("Enter a number: ");
                value = int.Parse(Console.ReadLine());

                if (value > 0)
                {
                    posCount++;
                }
                else if (value < 0)
                {
                    negCount++;
                }
                else
                {
                    zeroCount++;
                }
            }

            // Output to console
            Console.WriteLine($"There are {posCount} positive numbers, {negCount} negative numbers and {zeroCount} zeros.");
        }
    }
}
