using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var birthdays = new Dictionary<string, string>
        {
            {"Alice", "1995/03/15"},
            {"Bob", "1988/07/22"},
            {"Charlie", "2000/11/08"},
            {"Diana", "1992/01/30"},
            {"Eve", "1997/09/12"}
        };

        Console.WriteLine("People in the database:");
        foreach (var name in birthdays.Keys)
        {
            Console.WriteLine(name);
        }

        Console.Write("\nEnter a person's name: ");
        string input = Console.ReadLine();

        if (birthdays.ContainsKey(input))
        {
            Console.WriteLine($"{input}'s birthday is {birthdays[input]}");
        }
        else
        {
            Console.WriteLine($"Sorry, we don't have the birthday information for {input}");
        }
    }
}