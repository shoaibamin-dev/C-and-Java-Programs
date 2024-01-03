using System;

namespace FindIntType
{
    class Program
    {
        static void Main(string[] args)
        {
            // Input 5 numbers, one at a time
            // Check if it's positive, negative, or zero
            for (int i = 0; i < 5; i++)
            {
                // Get input from the console
                Console.Write("Enter a number: ");
                int input = int.Parse(Console.ReadLine());

                // Calculate the Int Type
                int output = FindIntType(input);

                // Output to the console if it's positive, negative, or zero
                switch (output)
                {
                    case 0:
                        Console.WriteLine("The number is zero.");
                        break;
                    case 1:
                        Console.WriteLine("The number is positive.");
                        break;
                    case -1:
                        Console.WriteLine("The number is negative.");
                        break;
                    default:
                        Console.WriteLine("Invalid input.");
                        break;
                }
            }
        }

        static int FindIntType(int input)
        {
            // If input is zero, return zero
            if(input == 0)
            {
                return 0;
            }
            // If input is positive, return 1
            else if (input == Math.Abs(input))
            {
                return 1;
            }
            // Else number is negative, return -1
            else { return -1; }
        }
    }
}
