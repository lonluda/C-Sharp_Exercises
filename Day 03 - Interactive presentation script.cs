using System;

namespace Printdata;

class App
{
    static void Main(string[] args)
    {

        string ?name;
        string ?surname;
        string ?raw_age;

        int age = 0;
        bool isvalid;

        Console.WriteLine("Hello !");

        Console.WriteLine("What's your name ?");
        name = Console.ReadLine();

        Console.WriteLine("What's your surname ?");
        surname = Console.ReadLine();

        Console.WriteLine("How old are you ?");
        raw_age = Console.ReadLine();

        isvalid = int.TryParse(raw_age, out age);

        if (isvalid)
        {

            Console.WriteLine($"Hello {name} {surname} ! \nYou're {age} years old.");

        }
        else
        {
            Console.WriteLine($"Hello {name} {surname} ! \nWe don't know your age.");
        }
    }
}
