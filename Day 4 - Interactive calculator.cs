using System;

namespace Calculator;

class CalculatorApp
{
    static void Main(string[] args)
    {
        int menu_selection;

        int a;
        int b;

        Console.WriteLine("Select the operation you desire:\n");
        Console.WriteLine("1. Sum \n2. Subtraction \n3. Multiplication \n4. Division \n5. Exit \n");
        string? raw_input = Console.ReadLine();

        bool isvalid_selection = int.TryParse(raw_input, out menu_selection);

        if (isvalid_selection && menu_selection > 0 && menu_selection < 6)
        {
            if (menu_selection == 5)
            {
                Environment.Exit(0);
            }

            Console.Clear();
            Console.WriteLine("Inserisci il primo valore: ");
            string? first_number = Console.ReadLine();

            Console.WriteLine("Inserisci il secondo valore: ");
            string? second_number = Console.ReadLine();


            bool first_number_isvalid = int.TryParse(first_number, out a);
            bool second_number_isvalid = int.TryParse(second_number, out b);

            if (!first_number_isvalid || !second_number_isvalid)
            {
                Console.WriteLine("Inserisci solo numeri validi !");
                return;
            }

            if (menu_selection == 1)
            {
                Console.WriteLine("\nResult: " + sum(a, b));
            }
            else if (menu_selection == 2)
            {
                Console.WriteLine("\nResult: " + subtraction(a, b));
            }
            else if (menu_selection == 3)
            {
                Console.WriteLine("\nResult: " + multiplication(a, b));
            }
            else if (menu_selection == 4)
            {
                Console.WriteLine("\nResult: " + division(a, b));
            }
        }
        else
        {
            Console.WriteLine("Select a correct menu value ! ");
        }
    }
    
    static int sum(int a, int b)
        {
            return a + b;
        }

    static int subtraction(int a, int b)
    {
        return a - b;
    }

    static int multiplication(int a, int b)
    {
        return a * b;
    }

    static int division(int a, int b)
    {

        if (b == 0)
        {
            Console.WriteLine("Is not possible divide by 0 !");
            return 0;
        }
        else
        {
            return a / b;
        }
           
    }

}

