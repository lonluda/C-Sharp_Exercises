using System;

namespace ListExercise;

class App
{

    static void Main(string[] args)
    {
        List<string> values = GainValue();
        PrintValues(values);
    }

    static List<string> GainValue()
    {

        List<string> rawValues = new List<string>();

        for(int i = 0; i < 3; i++){
            Console.Write("Insert new value: ");
            string rawInput = Console.ReadLine();
            rawValues.Add(rawInput);

        }

        return rawValues;

    }

    static void PrintValues(List<string> values)
    {
        foreach(string value in values)
        {
            Console.WriteLine($"A value is {value}");
        }
    }
}
