using System;
using System.Collections.Generic;

// Bonus Challenge: Multiples List Generator
public class MultiplesListGenerator
{
    public static void Run()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        
        Console.Write("Enter the desired length: ");
        int length = int.Parse(Console.ReadLine());
        
        var multiples = new List<int>();
        for (int i = 1; i <= length; i++)
        {
            multiples.Add(number * i);
        }
        Console.WriteLine(string.Join(", ", multiples));
    }
}

// Bonus Challenge: Remove Consecutive Duplicate Letters    
public class RemoveConsecutiveDuplicates
{
    public static void Run()
    {
        Console.WriteLine("\n--- Challenge 2: Remove Consecutive Duplicate Letters ---");
        string input = Helpers.ReadString("Enter a string: ");
        if (string.IsNullOrEmpty(input))
        {
            Console.WriteLine("No input provided.");
            return;
        }
        string result = string.Empty;
        char last = '\0';
        foreach (char c in input)
        {
            if (c != last)
            {
                result += c;
                last = c;
            }
        }
        Console.WriteLine($"Result: {result}");
    }
}
