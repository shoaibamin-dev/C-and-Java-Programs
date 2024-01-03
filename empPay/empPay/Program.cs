using System;

namespace empPay
{
    class Program
    {
        static void Main(string[] args)
        {
            // Per week employee recieves $200
            // If less than 48 hours -> recieves $10 extra for each hour under 48 hours
            // Total wage for wek is $200 + (10 * hours under 48 hrs)

            // Greater than 40, less than 48
            // Check the number of emp that got each bonus amount

            int[] bonus = new int[8];

            Console.WriteLine("Enter 0 to exit. ");
            Console.Write("Enter the hours: ");
            int hrs = int.Parse(Console.ReadLine());

            while (hrs != 0)
                if (hrs > 40 && hrs < 48)
                {
                    int extra = 48 - hrs;
                    Console.WriteLine($"Extra hours worked is {extra}");

                    ++bonus[extra];
                    Console.WriteLine($"Bonus[extra] is bonus[{extra}] {bonus[extra]}.");

                    double wage = (extra * 10) + 200;
                    Console.WriteLine($"The total wage for the week is: {wage}");

                    Console.WriteLine("Enter 0 to exit. ");
                    Console.Write("Enter the hours: ");

                    hrs = int.Parse(Console.ReadLine());

                }

            Console.WriteLine("Extra hours\tNumber");

            for(int i=1; i < bonus.Length; i++)
            {
                Console.WriteLine($"${i}\t\t{bonus[i]}");
            }
        }
    }
}
