using System;

// Getting two numbers form the user and adding the two numbers and display the result to the user

class AdditionApp
{
    static void Main()
    {
        int num1, num2, sum;

        // Get input 1
        Console.Write("Enter the first number: ");
        num1 = int.Parse(Console.ReadLine());

        // Get input 2
        Console.Write("Enter the second number: ");
        num2 = int.Parse(Console.ReadLine());

        // Add the two inputs together
        sum = num1 + num2;

        // Output to the console
        // Console.WriteLine("The sum of " + num1 + " and " + num2 + " is " + sum);
        Console.WriteLine($"The sum of {num1} and {num2} is {sum}");
    }

}
