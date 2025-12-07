using System;

class Program
{
    static void GuessNumber(int userNumber)
    {
        Random rnd = new Random();
        int randomNumber = rnd.Next(1, 101);

        if (userNumber == randomNumber)
        {
            Console.WriteLine("Success! You guessed it!");
        }
        else
        {
            Console.WriteLine($"Fail! Your number: {userNumber}, Random number: {randomNumber}");
        }
    }

    static void Main()
    {
        Console.Write("Enter a number (1-100): ");
        int number = int.Parse(Console.ReadLine());
        GuessNumber(number);
    }
}