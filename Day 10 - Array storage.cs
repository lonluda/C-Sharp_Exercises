using System;

class ArrayLoader
{
    public static void Main()
    {

        int[] values = new int[5];

        string[] ordine = { "primo", "secondo", "terzo", "quarto", "quinto" };

        for (int i = 0; i < values.Length; i++)
        {
            Console.Write("Inserisci il " + ordine[i] + " numero: ");

            string user_value = Console.ReadLine();
            int.TryParse(user_value, out values[i]);
        }

        for(int i=0; i < values.Length; i++)
        {
            Console.Write("Il " + ordine[i] + " numero è : ");
            Console.WriteLine(values[i]);
        }

    }
}
