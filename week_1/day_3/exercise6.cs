using System;

class Program
{
    static void MakeShirt(string size = "Large", string text = "I love C#")
    {
        Console.WriteLine($"The size of the shirt is {size} and the text is '{text}'.");
    }

    static void Main()
    {
        MakeShirt();
        MakeShirt("Medium");
        MakeShirt("Small", "Python is cool");
        MakeShirt(text: "C# rocks!", size: "XL");
    }
}