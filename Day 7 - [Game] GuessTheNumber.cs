using System;

namespace GuessTheNumber;

class GuessTheNumber
{
    static void Main()
    {
        WelcomeMessage();
        PlayGame();
    }

    static void WelcomeMessage()
    {
        Console.Clear();
        Console.WriteLine("Welcome in GuessTheNumber game.");
        Console.WriteLine("A simple game wrote in C#\n");

        Console.WriteLine("Guess the lucky number between 1-10 for win !\n");

        Console.WriteLine("Press ENTER when you're ready.");
        Console.ReadLine();

    }

    static void PlayGame()
    {
        Console.Clear();
        Console.WriteLine("Select the lucky number: ");
        string rawInput = Console.ReadLine();

        bool inputIsValid = int.TryParse(rawInput, out int luckyNumber);

        if (!inputIsValid)
        {
            Console.WriteLine("Insert only numbers !");
            return;
            
        }

        if (luckyNumber < 1 || luckyNumber > 10)
        {
            Console.WriteLine("Insert only NUMBER between 1 and 10 !");
            return;
        }

        Random rnd = new Random();

        int casualNumber = rnd.Next(1, 11);

        if (luckyNumber == casualNumber)
        {
            Console.Clear();
            Console.WriteLine("The lucky number was " + casualNumber + "\n");
            Console.WriteLine("You Win !!! ");
        }
        else
        {
            Console.Clear();
            Console.WriteLine("The lucky number was " + casualNumber + "\n");
            Console.WriteLine("I'm sorry, you lose");
        }
    }
}
