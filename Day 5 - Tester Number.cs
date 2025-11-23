using System;

namespace TestNumber;

class TesterNumber
{
    static void Main(string[] args)
    {

        Console.WriteLine("Insert a number: ");
        string raw_input = Console.ReadLine();

        bool isvalid = int.TryParse(raw_input, out int result);

        if (isvalid)
        {
            if (result > 0)
            {
                Console.WriteLine("Positive number !");
            }
            else if (result < 0)
            {
                Console.WriteLine("Negative number !");
            }
            else if (result == 0)
            {
                Console.WriteLine("Number is zero !");
            }
        }
        else
        {
            Console.WriteLine("Insert a valid number !");
        }
    }
}
