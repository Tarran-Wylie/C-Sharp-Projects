using System;

class Program
{
    static void Main()
    {
        // Instantiate the MathOperations class
        MathOperations mathOps = new MathOperations();

        // Call the method with two numbers
        mathOps.PerformMathAndDisplay(10, 20);

        // Call the method with named parameters
        mathOps.PerformMathAndDisplay(num1: 7, num2: 15);

        // Infinite loop to keep the console window open
        while (true)
        {
            // Perform any desired actions within the loop
            // To exit the loop and close the console window, use a break statement or another condition
        }
    }
}
