using System;

class Program
{
    static int GetRandomTemp(string season)
    {
        Random rnd = new Random();
        int min = -10, max = 40;

        if (season == "winter") { min = -10; max = 16; }
        if (season == "spring") { min = 0; max = 23; }
        if (season == "summer") { min = 16; max = 40; }
        if (season == "autumn") { min = 0; max = 23; }

        return rnd.Next(min, max + 1);
    }

    static void Main()
    {
        Console.Write("Enter a season (winter/spring/summer/autumn): ");
        string season = Console.ReadLine().ToLower();
        
        int temp = GetRandomTemp(season);
        Console.WriteLine($"The temperature right now is {temp} degrees Celsius.");

        if (temp < 0)
            Console.WriteLine("It's freezing! Wear a heavy coat.");
        else if (temp < 16)
            Console.WriteLine("It's cold. Bring a jacket.");
        else if (temp < 24)
            Console.WriteLine("It's comfortable. Enjoy the weather!");
        else
            Console.WriteLine("It's hot! Stay hydrated.");
    }
}