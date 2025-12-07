using System;

class Program
{
    static void DescribeCity(string city, string country = "Iceland")
    {
        Console.WriteLine($"{city} is in {country}.");
    }

    static void Main()
    {
        DescribeCity("Reykjavik");
        DescribeCity("Paris", "France");
        DescribeCity("New York", "USA");
        DescribeCity("Akureyri");
    }
}