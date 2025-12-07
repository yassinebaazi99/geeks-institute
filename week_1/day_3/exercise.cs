using System;
using System.Collections.Generic;

// Exercise 1: Convert Lists to Dictionaries
public class ListsToDictionaries
{
    public static void Run()
    {
        Console.WriteLine("=== Exercise 1: Convert Lists to Dictionaries ===\n");
        
        List<string> keys = new List<string> { "Ten", "Twenty", "Thirty" };
        List<int> values = new List<int> { 10, 20, 30 };
        
        Dictionary<string, int> dict = new Dictionary<string, int>();
        
        for (int i = 0; i < keys.Count; i++)
        {
            dict[keys[i]] = values[i];
        }
        
        // Print the dictionary
        Console.Write("{");
        int count = 0;
        foreach (var kvp in dict)
        {
            Console.Write($"\"{kvp.Key}\": {kvp.Value}");
            if (count < dict.Count - 1)
                Console.Write(", ");
            count++;
        }
        Console.WriteLine("}");
    }
}

// Exercise 2: Cinemax #2
public class Cinemax
{
    public static void Run()
    {
        Console.WriteLine("\n=== Exercise 2: Cinemax #2 ===\n");
        
        Dictionary<string, int> family = new Dictionary<string, int>
        {
            {"rick", 43}, 
            {"beth", 13}, 
            {"morty", 5}, 
            {"summer", 8}
        };
        
        double totalCost = 0;
        
        Console.WriteLine("Family Ticket Prices:");
        Console.WriteLine("---------------------");
        
        foreach (var member in family)
        {
            string name = member.Key;
            int age = member.Value;
            double price = CalculateTicketPrice(age);
            
            Console.WriteLine($"{name} (Age {age}): ${price:F2}");
            totalCost += price;
        }
        
        Console.WriteLine("---------------------");
        Console.WriteLine($"Total Family Cost: ${totalCost:F2}");
    }
    
    private static double CalculateTicketPrice(int age)
    {
        if (age < 3)
            return 0;
        else if (age >= 3 && age <= 12)
            return 10;
        else
            return 15;
    }
}

// Bonus: Cinemax with User Input
public class CinemaxBonus
{
    public static void Run()
    {
        Console.WriteLine("\n=== Bonus: Cinemax with User Input ===\n");
        
        Dictionary<string, int> family = new Dictionary<string, int>();
        
        Console.Write("How many family members? ");
        int numberOfMembers = int.Parse(Console.ReadLine());
        
        for (int i = 0; i < numberOfMembers; i++)
        {
            Console.WriteLine($"\nFamily Member {i + 1}:");
            Console.Write("  Enter name: ");
            string name = Console.ReadLine();
            Console.Write("  Enter age: ");
            int age = int.Parse(Console.ReadLine());
            family[name] = age;
        }
        
        double totalCost = 0;
        
        Console.WriteLine("\n--- Family Ticket Prices ---");
        Console.WriteLine("---------------------");
        
        foreach (var member in family)
        {
            string name = member.Key;
            int age = member.Value;
            double price = CalculateTicketPrice(age);
            
            Console.WriteLine($"{name} (Age {age}): ${price:F2}");
            totalCost += price;
        }
        
        Console.WriteLine("---------------------");
        Console.WriteLine($"Total Family Cost: ${totalCost:F2}");
    }
    
    private static double CalculateTicketPrice(int age)
    {
        if (age < 3)
            return 0;
        else if (age >= 3 && age <= 12)
            return 10;
        else
            return 15;
    }
}

// Main Program
class Program
{
    static void Main()
    {
        // Exercise 1
        ListsToDictionaries.Run();
        
        // Exercise 2
        Cinemax.Run();
        
        // Bonus
        CinemaxBonus.Run();
    }
}


