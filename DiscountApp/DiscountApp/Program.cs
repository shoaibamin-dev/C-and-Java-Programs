using System;

namespace DiscountApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables
            double discount, netpay;

            /*
            // Read inputs
            Console.Write("Enter price for the first item: ");
            price1 = double.Parse(Console.ReadLine());

            Console.Write("Enter price for the first item: ");
            price2 = double.Parse(Console.ReadLine());

            Console.Write("Enter price for the first item: ");
            price3 = double.Parse(Console.ReadLine());
            
            
            // Perform calculations
            sum = price1 + price2 + price3;
            discount = sum * 0.1;

            */

            int counter = 0;
            double totalprice = 0;
            /*
            while (counter < 3)
            {

                Console.WriteLine($"Counter before: {counter}");
                // Read input price
                Console.Write($"Enter price for item {counter}: ");
                totalprice += + double.Parse(Console.ReadLine());

                counter++;
                Console.WriteLine($"Counter after: {counter}");
            }
            */

            for (int i = 1; i <=3; i++)
            {
                Console.WriteLine($"Counter before: {counter}");
                // Read input price
                Console.Write($"Enter price for item {counter}: ");
                totalprice += +double.Parse(Console.ReadLine());

                counter++;
                Console.WriteLine($"Counter after: {counter}");
            }

            discount = totalprice * 0.1;

            netpay = totalprice - discount;

            // Output
            Console.WriteLine($"The total price of the three items is ${totalprice}. A 10% discount, ${discount} was applied. The net amount to be paid is ${netpay}");


        }
    }
}
