using System;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            Console.Write("Please enter the package weight: ");
            decimal weight = decimal.Parse(Console.ReadLine());

            // Check if the weight is greater than 50
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                Console.ReadLine();
                return;
            }

            Console.Write("Please enter the package width: ");
            decimal width = decimal.Parse(Console.ReadLine());

            Console.Write("Please enter the package height: ");
            decimal height = decimal.Parse(Console.ReadLine());

            Console.Write("Please enter the package length: ");
            decimal length = decimal.Parse(Console.ReadLine());

            decimal dimensionsTotal = width + height + length;

            // Check if the dimensions total is greater than 50
            if (dimensionsTotal > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                Console.ReadLine();
                return;
            }

            // Calculate the quote
            decimal quote = (dimensionsTotal * weight) / 100;

            Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");
            Console.WriteLine("Thank you!");

            Console.ReadLine();
        }
    }
}
