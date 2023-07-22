using System;

class Program
{
    static void Main()
    {
        // Instantiate two Employee objects and assign values to their properties
        Employee employee1 = new Employee { Id = 101, FirstName = "John", LastName = "Doe" };
        Employee employee2 = new Employee { Id = 102, FirstName = "Jane", LastName = "Smith" };
        Employee employee3 = new Employee { Id = 101, FirstName = "John", LastName = "Doe" }; // An employee with the same Id as employee1

        // Compare the Employee objects using the overloaded "==" operator and display the results
        Console.WriteLine($"Employee1 == Employee2: {employee1 == employee2}"); // Should be false
        Console.WriteLine($"Employee1 == Employee3: {employee1 == employee3}"); // Should be true

        // Compare the Employee objects using the overloaded "!=" operator and display the results
        Console.WriteLine($"Employee1 != Employee2: {employee1 != employee2}"); // Should be true
        Console.WriteLine($"Employee1 != Employee3: {employee1 != employee3}"); // Should be false

        // Infinite loop to keep the console window open
        while (true)
        {
            // Perform any desired actions within the loop
            // To exit the loop and close the console window, use a break statement or another condition
        }
    }
}
