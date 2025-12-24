using System;
using System.Data;
using System.Threading.Channels;

namespace App;

class MainApp
{
    private static void Main()
    {

        MenuSelector();

    } 

    private static void PrintMenu()
    {
        Console.Clear();
        Console.WriteLine("Welcome user,\nselect an option:\n");
        Console.WriteLine("1. Sum numbers");
        Console.WriteLine("2. Find Max");
        Console.WriteLine("3. Exit");
        Console.WriteLine();
    }

    private static int ValidateMenuInput(string input)
    {
        bool isValid = false;

        if (input == null || input.Length == 0) return 0;
        else
        {
            isValid = int.TryParse(input, out int parsedInput);

            if (parsedInput >= 1 && parsedInput <= 3) return parsedInput;
            else return 0;
 
        }

    }

    private static void MenuSelector()
    {
        
        bool running = true;

        while (running)
        {

        PrintMenu();

        string ?raw_input = Console.ReadLine();

        int choice = ValidateMenuInput(raw_input);

            switch (choice)
            {
                case 1: SumNumbers(); break;
                case 2: MaxNumber(); break;
                case 3: Console.WriteLine("Thank you for using my App !"); running = false; break;
            }

        }

    }

    private static void SumNumbers()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Insert two numbers to sum:\n");

            Console.WriteLine("First number:");
            string? rawFirstInput = Console.ReadLine();

            Console.WriteLine("Second number:");
            string? rawSecondInput = Console.ReadLine();

            if (rawFirstInput.Length == 0 || rawSecondInput.Length == 0) continue;
            else
            {
                if (TryNumberValidator(rawFirstInput, rawSecondInput, out int sum))
                {
                    Console.WriteLine($"\n The sum beetween {rawFirstInput} and {rawSecondInput} is {sum}.");
                    Console.ReadLine();
                    break;
                }
                else
                {
                    Console.WriteLine("Insert a valid numers to sum !");
                    Console.ReadLine();
                    break;
                }

            }

        }
    }

    private static bool TryNumberValidator(
        string rawFirstInput,
        string rawSecondInput,
        out int sum)
    {
        bool isParsableFirstInput = int.TryParse(rawFirstInput, out int parsedFirstInput);
        bool isParsableSecondInput = int.TryParse(rawSecondInput, out int parsedSecondInput);

        if(isParsableFirstInput && isParsableSecondInput)
        {
            sum = parsedFirstInput + parsedSecondInput;
            return true;
        }
        else
        {
            sum = 0;
            return false;
        }

    }

    private static void MaxNumber()
    {

        List<int> numbers = new List<int>();

        Console.Clear();
        Console.WriteLine("Insert numbers to compare:\n");
        Console.WriteLine("Insert '0' for interrupt the cycle and find the Max number.\n");

        while (true)
        {
            Console.WriteLine("\nInsert a new number:");

            string rawInput = Console.ReadLine();

            int validInput = MaxNumberValidator(rawInput);

            if (validInput == 0)
            {

                if (numbers.Count == 0)
                {
                    Console.WriteLine("No numbers inserted.");
                    Console.ReadLine();
                    return;
                }

                CalculateMax(numbers);
                break;
            }
            else if (validInput == -1)
            {
                {
                    Console.WriteLine("Enter valid numbers !!!");
                    Console.ReadLine();
                }

            }
            else if (validInput > 0)
            {
                numbers.Add(validInput);
            }

        }
    }

    private static int MaxNumberValidator(string rawInput)
    {
        if (rawInput.Length == 0) return -1;
        else
        {
            bool isParsable = int.TryParse(rawInput, out int parsedInput);

            if (!isParsable) return -1;
            else if (parsedInput > 0) return parsedInput;
            else if (parsedInput == 0) return 0;
            else return -1;
        }
    }

    private static void CalculateMax(List<int> numbers)
    {
        int higherNumber = 0;

        foreach(int number in numbers)
        {
            if(number >  higherNumber) {higherNumber = number;}
        }

        Console.WriteLine($"Highest number is {higherNumber}");
        Console.ReadLine();
        
    }

}
