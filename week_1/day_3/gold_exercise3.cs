using System;

class Program
{
    static int SumSequence(int x)
    {
        int xx = int.Parse(x.ToString() + x.ToString());
        int xxx = int.Parse(x.ToString() + x.ToString() + x.ToString());
        int xxxx = int.Parse(x.ToString() + x.ToString() + x.ToString() + x.ToString());
        
        return x + xx + xxx + xxxx;
    }

    static void Main()
    {
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        
        int result = SumSequence(number);
        Console.WriteLine($"Result: {result}");
    }
}