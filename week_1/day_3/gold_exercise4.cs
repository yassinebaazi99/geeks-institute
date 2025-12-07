using System;
using System.Collections.Generic;

class Program
{
    static Random rnd = new Random();

    static int ThrowDice()
    {
        return rnd.Next(1, 7);
    }

    static int ThrowUntilDoubles()
    {
        int throws = 0;
        while (true)
        {
            throws++;
            int dice1 = ThrowDice();
            int dice2 = ThrowDice();
            
            if (dice1 == dice2)
            {
                return throws;
            }
        }
    }

    static void MainSimulation()
    {
        var results = new List<int>();
        
        for (int i = 0; i < 100; i++)
        {
            int throwCount = ThrowUntilDoubles();
            results.Add(throwCount);
        }

        int totalThrows = 0;
        foreach (var count in results)
        {
            totalThrows += count;
        }

        double average = (double)totalThrows / results.Count;

        Console.WriteLine($"Total throws: {totalThrows}");
        Console.WriteLine($"Average throws to reach doubles: {average:F2}");
    }

    static void Main()
    {
        MainSimulation();
    }
}