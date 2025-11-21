using System;

namespace Printdata;

class App
{
    static void Main(string[] args)
    {

        string name = "John";
        string surname = "Doe";
        int age = 22;
        double height = 170;

        Console.WriteLine($"Hello {name} {surname} !\nYou're {age} years old and tall {height} centimeters.");
    }
}
