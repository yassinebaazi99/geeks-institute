using System;
using System.Collections.Generic;

class Song
{
    public List<string> Lyrics;

    public Song(List<string> lyrics)
    {
        Lyrics = lyrics;
    }

    public void SingMeASong()
    {
        foreach (var line in Lyrics)
        {
            Console.WriteLine(line);
        }
    }
}

class Program
{
    static void Main()
    {
        var stairway = new Song(new List<string>{
            "There's a lady who's sure",
            "all that glitters is gold",
            "and she's buying a stairway to heaven"
        });

        stairway.SingMeASong();
    }
}