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

        Console.WriteLine("Welcome! You can look up birthdays.");
        Console.Write("Enter a person's name: ");
        string name = Console.ReadLine();

        if (birthdays.ContainsKey(name))
        {
            Console.WriteLine($"{name}'s birthday is {birthdays[name]}");
        }
    }
}