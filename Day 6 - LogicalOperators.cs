using System;

namespace LogicalOperators;

class LogOperators
{
    public static void Main()
    {
        Console.WriteLine("Insert first value");
        string raw_first_value = Console.ReadLine();

        Console.WriteLine("Insert second value");
        string raw_second_value = Console.ReadLine();

        bool first_value_isvalid = int.TryParse(raw_first_value, out int first_value);
        bool second_value_isvalid = int.TryParse(raw_second_value, out int second_value);

        if (first_value_isvalid && second_value_isvalid)
        {


            if (first_value == 0 || second_value == 0)
            {
                Console.WriteLine("One value is equal to 0, impossible to continue.");
            }

            else if (first_value == second_value)
            {
                Console.WriteLine("First and Second value are equal");
            }

            else
            {
                Console.WriteLine("The two numbers are different, well done.");
            }
        }
        else
        {
            Console.WriteLine("Insert only numbers !");
        }

    }
}
