using System;
using System.Globalization;

namespace NumberAnalyzer;
class App
{
    public static bool isRunning = true;
    public static string ? NumbersToShow;
    public static List<float> enteredNumbers = new List<float>();

    static public void Main()
    {

        while (isRunning)
        {
            PrintHeader();

            // Print the input prompt and enter previously entered number.
            Dashboard(enteredNumbers);

            // Get the next user input
            getInput();
        }

        float numberOfElements = enteredNumbers.Count;
        float sumOfElements = runSumOfElements(enteredNumbers);
        float highestNumber = findHighestNumber(enteredNumbers);
        float lowestNumber = findLowestNumber(enteredNumbers);

        endMessage(numberOfElements, sumOfElements, highestNumber, lowestNumber);

    }

    static public void PrintHeader()
    {
        Console.Clear();
        Console.WriteLine("Welcome in NumberAnalyzer APP!\n\nInsert how many numbers you want and the APP will\n" +
                            "give you back different mathematical operations.\n\nWhen you've finished to enter numbers," +
                                " insert 'end' and press Enter button.");
    }

    static public void Dashboard(List<float> enteredNumbers)
    {

        NumbersToShow = "";

        foreach (float number in enteredNumbers)
            NumbersToShow += number + " ";

        Console.WriteLine($"\nInserted numbers: {NumbersToShow}");

    }

    static public void getInput()
    {
        Console.Write("\n> ");
        string ? rawInput = Console.ReadLine();

        bool isFloat = float.TryParse(rawInput, NumberStyles.Float, CultureInfo.InvariantCulture, out float number);
        if (isFloat) enteredNumbers.Add(number);
        if (rawInput == "end" || rawInput == "END") isRunning = false;


    }

    static public float runSumOfElements(List<float> enteredNumbers)
    {
        float sum = 0;

        foreach(float number in enteredNumbers)
        {
            sum += number;
        }

        return sum;
    }

    static public float findHighestNumber(List<float> enteredNumbers)
    {
        float highestNumber = 0;

        foreach(float number in enteredNumbers)
        {
            float testedNumber = number;
            if (number > highestNumber) highestNumber = testedNumber;

        }
        return highestNumber;

    }

    static public float findLowestNumber(List<float> enteredNumbers)
    {
        float lowestNumber = 999;

        foreach (float number in enteredNumbers)
        {
            if(number < lowestNumber) lowestNumber = number;
        }

        return lowestNumber;
    }
    
    static public void endMessage(float numberOfElements, float sumOfElements,
        float highestNumber, float lowestNumber)

    {
        Console.Clear();
        Console.WriteLine("\nThe elements entered are " + numberOfElements + ".");
        Console.WriteLine("\nThe sum of entered numbers is " + sumOfElements + ".");
        Console.WriteLine("\nThe highest number entered is " + highestNumber + ".");
        Console.WriteLine("\nThe lowest number entered is " + lowestNumber + ".");
    }

}
