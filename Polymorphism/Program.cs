using System;

// Create an interface called IQuittable with a void method Quit()
public interface IQuittable
{
    void Quit();
}

// Create the Employee class and inherit the IQuittable interface
public class Employee : IQuittable
{
    // Implement the Quit() method from the IQuittable interface
    public void Quit()
    {
        Console.WriteLine("Employee is quitting the job.");
    }
}

class Program
{
    static void Main()
    {
        // Polymorphism: Create an object of type IQuittable and initialize it with an Employee object
        IQuittable quittableEmployee = new Employee();

        // Call the Quit() method on the IQuittable object
        quittableEmployee.Quit();

        // Infinite loop to keep the console window open
        while (true)
        {
            // Perform any desired actions within the loop
            // To exit the loop and close the console window, use a break statement or another condition
        }
    }
}
