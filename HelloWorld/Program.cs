using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create a one-dimensional array of strings
        string[] texts = new string[3];

        // Ask the user to input some text
        Console.WriteLine("Enter some text:");
        string userInput = Console.ReadLine();

        // Loop through each string in the array and append user's text
        for (int i = 0; i < texts.Length; i++)
        {
            texts[i] = texts[i] + userInput; // Append user's text to each string
        }

        // Loop to print each string in the array
        foreach (string text in texts)
        {
            Console.WriteLine(text);
        }

        // Infinite loop to keep the console window open
        while (true)
        {
            // Perform any desired actions within the loop
            // To exit the loop and close the console window, use a break statement or another condition
        }

        // Create a list of strings with at least two identical strings
        List<string> items = new List<string>()
        {
            "Apple",
            "Banana",
            "Orange",
            "Mango",
            "Banana",
            "Grapes"
        };

        // Ask the user to select text to search for in the list
        Console.WriteLine("Enter text to search in the list:");
        string searchText = Console.ReadLine();

        // Loop to iterate through the list and find matching items
        bool foundMatch = false;
        for (int i = 0; i < items.Count; i++)
        {
            if (items[i] == searchText)
            {
                Console.WriteLine("Match found at index: " + i);
                foundMatch = true;
            }
        }

        // Check if the user's input is not on the list
        if (!foundMatch)
        {
            Console.WriteLine("The input is not on the list.");
        }

        // Create a list of strings with at least two identical strings
        List<string> itemsWithDuplicates = new List<string>()
        {
            "A",
            "B",
            "C",
            "D",
            "C"
        };

        // Create a HashSet to keep track of seen strings
        HashSet<string> seenStrings = new HashSet<string>();

        // Loop through each item in the list using foreach
        foreach (string item in itemsWithDuplicates)
        {
            // Check if the current item has already been seen
            if (seenStrings.Contains(item))
            {
                Console.WriteLine(item + " - this item is a duplicate");
            }
            else
            {
                Console.WriteLine(item + " - this item is unique");
                seenStrings.Add(item); // Add the item to the HashSet to mark it as seen
            }
        }

        // Infinite loop to keep the console window open
        while (true)
        {
            // Perform any desired actions within the loop
            // To exit the loop and close the console window, use a break statement or another condition
        }
    }
}

