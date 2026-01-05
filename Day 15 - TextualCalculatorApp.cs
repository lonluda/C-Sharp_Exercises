using System;
using System.ComponentModel.Design;
using System.Reflection;
using System.Runtime.ExceptionServices;
using System.Security.AccessControl;

namespace TextualCalculatorApp;

class App
{
    static private void Main()
    {
        bool running = true;

        while (running)
        {
            PrintMenu();
            GetUserInput();
        }

    }

    static private void PrintMenu()
    {
        Console.Clear();
        Console.WriteLine("Welcome in TextualCalculatorApp !");
        Console.WriteLine("\nWrite abbreviations for each mathematical operation:");
        Console.WriteLine("\n Sum = 'sum'\n Subtraction = 'sub'\n Division = 'div'\n Multiplication = 'mul'");
        Console.WriteLine("\nEg. for sum two numbers, write 'sum 5 10'.\n");
    }

    static private void GetUserInput()
    {
        Console.Write("> ");
        string ?raw_input = Console.ReadLine();

        if (raw_input?.Length == 0)
        {
            Console.WriteLine("Insert a command");
            Console.ReadLine();
        }

        else
            HandleUserInput(raw_input);

    }

    static private void HandleUserInput(string raw_input)
    {
        string[] words = raw_input.Split(" ");

        if (words.Length != 3)
        {
            Console.WriteLine("\nInput not valid insert only 3 input !");
            Console.WriteLine("Eg. Insert 'sum' '3' '10' for obtain the operation required.");
            Console.ReadLine();
        }
        else
        {
            bool firstValueIsValid = int.TryParse(words[1], out int parsedFirstValue);
            bool secondValueIsValid = int.TryParse(words[2], out int parsedSecondValue);

            if (firstValueIsValid && secondValueIsValid)
            {
                OperationSelector(words[0], parsedFirstValue, parsedSecondValue);
            } else {
                Console.WriteLine("Insert only valid number !");
            }
        }
    }

    static private void OperationSelector(string operation, int firstValue, int secondValue)
    {

        switch (operation.ToLower())
        {
            case "sum":
                SumNumbers(firstValue, secondValue, operation); break;

            case "sub":
                SubtractNumbers(firstValue, secondValue, operation); break;

            case "mul":
                MultiplicateNumbers(firstValue, secondValue, operation); break;

            case "div":
                DivideNumbers(firstValue, secondValue, operation); break;
        }

    }

    static private void SumNumbers(int firstValue, int secondValue, string operation)
    {
        int sum = firstValue + secondValue;

        PrintResult(sum, firstValue, secondValue, operation);
    }

    static private void SubtractNumbers(int firstValue, int secondValue, string operation)
    {
        int difference = firstValue - secondValue;

        PrintResult(difference, firstValue, secondValue, operation);
    }

    static private void MultiplicateNumbers(int firstValue, int secondValue, string operation)
    {
        int product = firstValue * secondValue;

        PrintResult(product, firstValue, secondValue, operation);
    }

    static private void DivideNumbers(int firstValue, int secondValue, string operation)
    {
        if (secondValue == 0)
        {
            Console.WriteLine("\nIs not possible to divide by 0 !");
            Console.ReadLine();
        }
        else
        {
            int quotient = firstValue / secondValue;

            PrintResult(quotient, firstValue, secondValue, operation);
        }
    }

    static private void PrintResult(int result, int firstValue, int secondValue, string operation)
    {

        switch (operation)
        {
            case "sum":
                Console.WriteLine($"\nThe sum beetween {firstValue} and {secondValue} is {result}.");
                break;

            case "sub":
                Console.WriteLine($"\nThe difference beetween {firstValue} and {secondValue} is {result}.");
                break;

            case "mul":
                Console.WriteLine($"\nThe multiplication beetween {firstValue} and {secondValue} is {result}.");
                break;

            case "div":
                Console.WriteLine($"\nThe quotient beetween {firstValue} and {secondValue} is {result}.");
                break;

        }

        Console.ReadLine();

}

}
