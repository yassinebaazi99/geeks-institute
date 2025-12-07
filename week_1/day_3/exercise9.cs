using System;
using System.Collections.Generic;

class Cat
{
    public string Name;
    public int Age;

    public Cat(string catName, int catAge)
    {
        Name = catName;
        Age = catAge;
    }
}

class Program
{
    static Cat FindOldestCat(List<Cat> cats)
    {
        Cat oldest = cats[0];
        foreach (var cat in cats)
        {
            if (cat.Age > oldest.Age)
            {
                oldest = cat;
            }
        }
        return oldest;
    }

    static void Main()
    {
        var cat1 = new Cat("Fluffy", 3);
        var cat2 = new Cat("Whiskers", 7);
        var cat3 = new Cat("Mittens", 5);

        var cats = new List<Cat> { cat1, cat2, cat3 };

        Cat oldestCat = FindOldestCat(cats);
        Console.WriteLine($"The oldest cat is {oldestCat.Name}, and is {oldestCat.Age} years old.");
    }
}