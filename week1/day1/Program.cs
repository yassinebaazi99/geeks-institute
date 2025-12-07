using System;
using System.Collections.Generic;

static int ReadInt(string prompt)
{
    while (true)
    {
        Console.Write(prompt);
        var s = Console.ReadLine();
        if (int.TryParse(s, out var n)) return n;
        Console.WriteLine("Invalid integer. Try again.");
    }
}

static double ReadDouble(string prompt)
{
    while (true)
    {
        Console.Write(prompt);
        var s = Console.ReadLine();
        if (double.TryParse(s, out var d)) return d;
        Console.WriteLine("Invalid number. Try again.");
    }
}

static string ReadString(string prompt)
{
    Console.Write(prompt);
    return Console.ReadLine() ?? string.Empty;
}

// Exercise 1: 
static void Exercise1()
{
   
    Console.WriteLine("Hello, World!");
}
// Exercise 2: Personal Info
static void Exercise2()
{
   
    string name = "yassine"; 
    int age = 25; 
    Console.WriteLine($"My name is {name} and I am {age} years old.");
}

// Exercise 3: The Calculator
static void Exercise3()
{
   
    int num1 = 8;
    int num2 = 12;
    int sum = num1 + num2;
    Console.WriteLine($"num1 = {num1}, num2 = {num2}, sum = {sum}");
}

// Exercise 4: The Bouncer (If/Else)
static void Exercise4()
{
    
    int userAge = ReadInt("Enter your age: ");
    if (userAge >= 18)
        Console.WriteLine("Access Granted.");
    else
        Console.WriteLine("Access Denied.");
}

// Exercise 5:
static void Exercise5()
{
  
    int i = 10;
    while (i >= 1)
    {
        Console.WriteLine(i);
        i--;
    }
    Console.WriteLine("Liftoff!");
}

// Exercise 6: 
static void SayHello(string name) => Console.WriteLine($"Hello, {name}!");
static void Exercise6()
{
    SayHello("Alice");
    SayHello("Bob");
    SayHello("Charlie");
}

// Exercise 7:
static void Exercise7()
{
    Console.WriteLine("\n--- Exercise 7: Even or Odd ---");
    for (int n = 1; n <= 10; n++)
    {
        string type = (n % 2 == 0) ? "even" : "odd";
        Console.WriteLine($"{n} is {type}");
    }
}

// Exercise 8:
static void Exercise8()
{
    Console.WriteLine("\n--- Exercise 8: Temperature Converter ---");
    double c = ReadDouble("Enter temperature in Celsius: ");
    double f = c * 9.0 / 5.0 + 32.0;
    Console.WriteLine($"{c} °C = {f:F1} °F");
}

// Exercise 9:
static void Exercise9()
{
    Console.WriteLine("\n--- Exercise 9: Number Swapper ---");
    int a = 5;
    int b = 10;
    Console.WriteLine($"Before: a = {a}, b = {b}");
    int temp = a;
    a = b;
    b = temp;
    Console.WriteLine($"After:  a = {a}, b = {b}");
}

// Exercise 10:
static void Exercise10()
{
    Console.WriteLine("\n--- Exercise 10: Simple Multiplication Table ---");
    int n = ReadInt("Enter a number for its multiplication table: ");
    for (int i = 1; i <= 10; i++)
        Console.WriteLine($"{n} x {i} = {n * i}");
}

// Triangle Pattern
static void TrianglePattern()
{
    Console.WriteLine("\n--- Triangle Pattern ---");
    for (int i = 1; i <= 5; i++)
    {
        for (int j = 0; j < i; j++) Console.Write('*');
        Console.WriteLine();
    }
}

// Reverse a Word 
static void ReverseAWord()
{
    Console.WriteLine("\n--- Reverse a Word (no built-ins) ---");
    Console.Write("Enter a word: ");
    string? word = Console.ReadLine();
    if (string.IsNullOrEmpty(word))
    {
        Console.WriteLine("No input provided.");
        return;
    }
    string reversed = "";
    for (int i = word.Length - 1; i >= 0; i--) reversed += word[i];
    Console.WriteLine($"Reversed: {reversed}");
}

static void MultiplesListGenerator()
{
    int number = ReadInt("Enter a number: ");
    int length = ReadInt("Enter the desired length: ");
    var multiples = new List<int>();
    for (int i = 1; i <= length; i++)
    {
        multiples.Add(number * i);
    }
    Console.WriteLine(string.Join(", ", multiples));
}

static void RemoveConsecutiveDuplicates()
{
    Console.WriteLine("\n--- Challenge 2: Remove Consecutive Duplicate Letters ---");
    string input = ReadString("Enter a string: ");
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


Exercise1();
Exercise2();
Exercise3();
Exercise4();
Exercise5();
Exercise6();
Exercise7();
Exercise8();
Exercise9();
Exercise10();
TrianglePattern();
ReverseAWord();
MultiplesListGenerator();
RemoveConsecutiveDuplicates();
