using System;
using System.Collections.Generic;
using System.Linq;

class Zoo
{
    public string Name;
    public List<string> Animals;

    public Zoo(string zooName)
    {
        Name = zooName;
        Animals = new List<string>();
    }

    public void AddAnimal(string newAnimal)
    {
        if (!Animals.Contains(newAnimal))
        {
            Animals.Add(newAnimal);
            Console.WriteLine($"{newAnimal} added to the zoo.");
        }
        else
        {
            Console.WriteLine($"{newAnimal} already exists in the zoo.");
        }
    }

    public void GetAnimals()
    {
        Console.WriteLine($"Animals in {Name}:");
        foreach (var animal in Animals)
        {
            Console.WriteLine(animal);
        }
    }

    public void SellAnimal(string animalSold)
    {
        if (Animals.Contains(animalSold))
        {
            Animals.Remove(animalSold);
            Console.WriteLine($"{animalSold} has been sold.");
        }
        else
        {
            Console.WriteLine($"{animalSold} not found in the zoo.");
        }
    }

    public Dictionary<string, List<string>> SortAnimals()
    {
        var sorted = Animals.OrderBy(a => a).ToList();
        var groups = new Dictionary<string, List<string>>();

        foreach (var animal in sorted)
        {
            string firstLetter = animal[0].ToString().ToUpper();
            if (!groups.ContainsKey(firstLetter))
            {
                groups[firstLetter] = new List<string>();
            }
            groups[firstLetter].Add(animal);
        }

        return groups;
    }

    public void GetGroups()
    {
        var groups = SortAnimals();
        foreach (var group in groups)
        {
            Console.WriteLine($"{group.Key}: {string.Join(", ", group.Value)}");
        }
    }
}

class Program
{
    static void Main()
    {
        Zoo newYorkZoo = new Zoo("New York Zoo");

        newYorkZoo.AddAnimal("Giraffe");
        newYorkZoo.AddAnimal("Elephant");
        newYorkZoo.AddAnimal("Bear");
        newYorkZoo.AddAnimal("Ape");
        newYorkZoo.AddAnimal("Cat");
        newYorkZoo.AddAnimal("Cougar");
        newYorkZoo.AddAnimal("Eel");
        newYorkZoo.AddAnimal("Emu");

        newYorkZoo.GetAnimals();

        Console.WriteLine();
        newYorkZoo.SellAnimal("Elephant");

        Console.WriteLine();
        newYorkZoo.GetGroups();
    }
}