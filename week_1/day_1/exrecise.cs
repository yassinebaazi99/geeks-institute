using System;
using System.Collections.Generic;

class Program
{
    static void FizzBuzz()
    {
        Console.WriteLine("\n--- FizzBuzz ---");
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());

        if (number % 3 == 0 && number % 5 == 0)
            Console.WriteLine("FizzBuzz");
        else if (number % 3 == 0)
            Console.WriteLine("Fizz");
        else if (number % 5 == 0)
            Console.WriteLine("Buzz");
        else
            Console.WriteLine("unfizzbuzzable");
    }

    static void Greeting()
    {
        Console.Write("Welcome to C# Programming!");
        string name = "Yassine";
        int age = 26;
        Console.WriteLine($" My name is {name} and I am {age} years old.");
    }

    static void Calculator()
    {
        Console.WriteLine("\n--- Simple Calculator ---");
        Console.Write("Enter first number: ");
        double num1 = double.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        double num2 = double.Parse(Console.ReadLine());
        double sum = num1 + num2;
        Console.WriteLine($"The sum of {num1} and {num2} is {sum}");
    }

    static void AgeChecker()
    {
        Console.WriteLine("\n--- Age Checker ---");
        Console.Write("Enter your age: ");
        int age = int.Parse(Console.ReadLine());
        if (age >= 18)
            Console.WriteLine("access granted.");
        else
            Console.WriteLine("access denied.");
    }

    static void Countdown()
    {
        Console.WriteLine("\n--- Countdown from 10 to 1 ---");
        for (int i = 10; i >= 1; i--)
        {
            Console.WriteLine(i);
        }
    }

    static string SayHello(string name)
    {
        return $"Hello, {name}!";
    }

    static void EvenOddChecker()
    {
        Console.WriteLine("\n--- Even or Odd Checker ---");
        for (int n = 1; n <= 10; n++)
        {
            if (n % 2 == 0)
                Console.WriteLine($"{n} is even.");
            else
                Console.WriteLine($"{n} is odd.");
        }
    }

    static void CelsiusToFahrenheit()
    {
        Console.WriteLine("\n--- Celsius to Fahrenheit Converter ---");
        Console.Write("Enter temperature in Celsius: ");
        double celsius = double.Parse(Console.ReadLine());
        double fahrenheit = (celsius * 9 / 5) + 32;
        Console.WriteLine($"{celsius}°C is {fahrenheit}°F");
    }

    static void SwapVariables()
    {
        Console.WriteLine("\n--- Variable Swapper ---");
        int a = 5;
        int b = 10;
        Console.WriteLine($"Before Swap: a = {a}, b = {b}");
        int temp = a;
        a = b;
        b = temp;
        Console.WriteLine($"After Swap: a = {a}, b = {b}");
    }

    static void MultiplicationTable()
    {
        Console.WriteLine("\n--- Multiplication Table ---");
        Console.Write("Enter a number: ");
        int number = int.Parse(Console.ReadLine());
        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine($"{number} x {i} = {number * i}");
        }
    }

    static void Main()
    {
        FizzBuzz();
        Greeting();
        Calculator();
        AgeChecker();
        Countdown();
        Console.WriteLine(SayHello("Yassine"));
        Console.WriteLine(SayHello("Omen"));
        Console.WriteLine(SayHello("hp"));
        EvenOddChecker();
        CelsiusToFahrenheit();
        SwapVariables();
        MultiplicationTable();
    }
}



