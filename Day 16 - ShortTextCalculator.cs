Dimmi cosa ne pensi : 

using System;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

namespace ShortTextCalculator;

class App
{
    static private void Main()
    {

        bool running = true;
        int total = 0;

        while (running)
        {
            WelcomeMessage();

            string rawInput = GetUserInput();

            if (rawInput.Length == 0)
            {
                Console.WriteLine("You have to insert at least 2 numbers and 1 operation.\nEg. <number> <operator> <number>");
                Console.ReadLine();
                continue;
            }

            string[] strings = SplitUserInput(rawInput);

            if (strings.Length != 3)
            {
                Console.WriteLine("Insert a valid input ! Eg. <number> <operator> <number>");
                Console.ReadLine();
                continue;
            }

            bool isParsable = ParseInput(strings, out int parsedFirstNumber, out int parsedSecondNumber);

            if (!isParsable)
            {
                Console.WriteLine("Impossibile use one of two inserted number. Please check!");
                Console.ReadLine();
                continue;
            }

            bool isValidOperation = TryEvaluateOperation(strings[1], out string validatedOperation);

            if (!isValidOperation)
            {
                Console.WriteLine("Operation sign doesn't recognized ! Insert only '+' , '-', '*' and '/'.\n");
                Console.ReadLine();
                continue;
            }

            switch (validatedOperation)
            {
                case "sum":
                    total = Sum(parsedFirstNumber, parsedSecondNumber);
                    break;

                case "dif":
                    total = Subtraction(parsedFirstNumber, parsedSecondNumber);
                    break;

                case "mul":
                    total = Multiplication(parsedFirstNumber, parsedSecondNumber);
                    break;

                case "div":
                    total = Division(parsedFirstNumber, parsedSecondNumber, out bool divideByZero);

                    if(divideByZero)
                        Console.WriteLine("You can't divide by zero!");
                        break;
                default:
                    Console.WriteLine("Operation not possible. Please t");
                    break;
            }

            PrintResults(total);

        }
    }

    static private void WelcomeMessage()
    {
        Console.Clear();
        Console.WriteLine("Welcome in ShortTextCalculator!\n");
        Console.WriteLine("In this APP you can write fast mathematical operations,\n" +
            "using the following format <number> <operation> <number>\n" +
            "eg. '2' '*' '2' and the APP will deal the result.\n");
    }

    static private string GetUserInput()
    {
        Console.Write("> ");
        string? rawInput = Console.ReadLine();

        return rawInput;
    }

    static private string[] SplitUserInput(string rawInput)
    {
        string[] strings = rawInput.Split(" ");
        return strings;
    }

    static private bool ParseInput(string[] strings, out int parsedFirstNumber, out int parsedSecondNumber)
    {
        bool isValidFirstNumber = int.TryParse(strings[0], out parsedFirstNumber);
        bool isValidSecondNumber = int.TryParse(strings[2], out parsedSecondNumber);

        if (isValidFirstNumber && isValidSecondNumber)
            return true;
        else
            return false;
    }

    static private bool TryEvaluateOperation(string operation, out string validatedOperation)
    {

        operation = operation.ToLower();

        switch (operation)
        {
            case "+":
                validatedOperation = "sum";
                return true;

            case "-":
                validatedOperation = "dif";
                return true;
            case "*":
                validatedOperation = "mul";
                return true;
            case "/":
                validatedOperation = "div";
                return true;
            default:
                validatedOperation = "none";
                return false;
        }
    }

    static private int Sum(int parsedFirstNumber, int parsedSecondNumber)
    {
        int sum = parsedFirstNumber + parsedSecondNumber;
        return sum;

    }

    static private int Subtraction(int parsedFirstNumber, int parsedSecondNumber)
    {
        int difference = parsedFirstNumber - parsedSecondNumber;
        return difference;
    }

    static private int Multiplication(int parsedFirstNumber, int parsedSecondNumber)
    {
        int product = parsedFirstNumber * parsedSecondNumber;
        return product;
    }

    static private int Division(int parsedFirstNumber, int parsedSecondNumber, out bool divideByZero)
    {
        divideByZero = false;

        if (parsedSecondNumber != 0)
        {
            int quotient = parsedFirstNumber / parsedSecondNumber;
            return quotient;
        }
        else
        {
            divideByZero = true;
            return 0;
        }
    }

    static private void PrintResults(int total)
    {
        Console.WriteLine($"\nThe result is {total}");
        Console.ReadLine();
    }

}
