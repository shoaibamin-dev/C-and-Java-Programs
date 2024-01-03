using System;

namespace Multiplication
{
    class Program
    {
        private static Random rand = new Random();
        static void Main(string[] args)
        {
            // Infinite loop
            while (true)
            {
                int input;

                // Generate a question, with two numbers
                int correctAnswer = GenerateQ();
                do
                {
                    // Read the console input
                    input = int.Parse(Console.ReadLine());

                    // Check if they input the correct answer
                    if (input == correctAnswer)
                    {
                        Console.WriteLine(correctResponse());
                    }
                    // If input is -1, exit the program
                    else if (input == -1)
                    {
                        Console.WriteLine("Exiting the program!");
                        Environment.Exit(0);
                    }
                    // Else answer is incorrect
                    else
                    {
                        Console.WriteLine(incorrectResponse());
                        Console.WriteLine("Enter -1 to exit.");
                    }

                }
                while (input != correctAnswer); // Loop until they get the correct answer
            }
        }

        static string correctResponse()
        {
            // Array of positive responses
            string[] posResponses = { "Very good!", "Excellent.", "Nice work!", "Keep up the good work!" };

            // Return a random response from the array
            return posResponses[rand.Next(0, 4)];
        }

        static string incorrectResponse()
        {
            // Array of incorrect responses
            string[] responses = { "No!", "Please try again.", "Wrong.", "Try once more!" };

            // Return a random response from the array
            return responses[rand.Next(0, 4)];
        }

        static int GenerateQ()
        {
            // Generate two random numbers 0-10
            int[] num = { rand.Next(0, 11), rand.Next(0, 11) };

            // Multiply them together to get the corect answer
            int correctAnswer = num[0] * num[1];

            // Output the question to the console
            Console.Write($"What is {num[0]} times {num[1]}?");

            // Return the correct answer to the main method
            return correctAnswer;
        }
    }
}
