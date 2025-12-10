using System;

namespace FindMaxNumber;

class App
{
    static void Main(string[] args)
    {
        List<int> user_input_list = new List<int>();

        while (true)
        {
            string raw_input = PrintDialog();
            int parsedNumber = CheckRawInput(raw_input);
            bool IsValid = CheckIfValid(parsedNumber);

            if (IsValid) user_input_list.Add(parsedNumber);
            else Close(user_input_list);
        }    
    }

    static string PrintDialog()
    {
        Console.Clear();
        Console.WriteLine("Insert a number: ");
        
        string raw_input = Console.ReadLine();

        return raw_input;

    }

    static int CheckRawInput(string raw_input)
    {

        int.TryParse(raw_input, out int clean_user_input);

        if (clean_user_input > 0 && clean_user_input < 1000)
        {
            return clean_user_input;
        }else
        {
            return 0;
        }

    }

    static bool CheckIfValid(int toValidInput)
    {
        if (toValidInput > 0) return true;
        else return false;
    }

    static void Close(List<int> user_input_list)
    {

        int highestNumber = findHighestNumber(user_input_list);


        Console.Clear();

        Console.WriteLine("You entered these values: ");
        foreach(int val in user_input_list)
        {
            Console.WriteLine($"{val}");
        }

        Console.WriteLine($"The highest number was: {highestNumber}");
        
        Console.ReadLine();
        Environment.Exit(0);

    }

    static int findHighestNumber(List<int> user_input_list)
    {
        if (user_input_list.Count > 0)
            return user_input_list.Max();
        
        return 0;
    }

}
