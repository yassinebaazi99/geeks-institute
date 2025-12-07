using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        var brand = new Dictionary<string, object>
        {
            {"name", "Zara"},
            {"creation_date", 1975},
            {"creator_name", "Amancio Ortega Gaona"},
            {"type_of_clothes", new List<string>{"men", "women", "children", "home"}},
            {"international_competitors", new List<string>{"Gap", "H&M", "Benetton"}},
            {"number_stores", 7000},
            {"major_color", new Dictionary<string, List<string>>
                {
                    {"France", new List<string>{"blue"}},
                    {"Spain", new List<string>{"red"}},
                    {"US", new List<string>{"pink", "green"}}
                }
            }
        };

        brand["number_stores"] = 2;
        Console.WriteLine($"Number of stores: {brand["number_stores"]}");

        var clothes = (List<string>)brand["type_of_clothes"];
        Console.WriteLine($"Zara's clients are: {string.Join(", ", clothes)}");

        brand["country_creation"] = "Spain";

        if (brand.ContainsKey("international_competitors"))
        {
            var competitors = (List<string>)brand["international_competitors"];
            competitors.Add("Desigual");
        }

        brand.Remove("creation_date");

        var competitorsList = (List<string>)brand["international_competitors"];
        Console.WriteLine($"Last competitor: {competitorsList[competitorsList.Count - 1]}");

        var colors = (Dictionary<string, List<string>>)brand["major_color"];
        Console.WriteLine($"US colors: {string.Join(", ", colors["US"])}");

        Console.WriteLine($"Number of items: {brand.Count}");

        Console.WriteLine($"Keys: {string.Join(", ", brand.Keys)}");

        var more_on_zara = new Dictionary<string, object>
        {
            {"creation_date", 1975},
            {"number_stores", 10000}
        };

        foreach (var item in more_on_zara)
        {
            brand[item.Key] = item.Value;
        }

        Console.WriteLine($"Number of stores: {brand["number_stores"]}");
    }
}


