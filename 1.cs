using System;

class Program
{
    static void Main()
    {
        string original = "Hello World";
        string toInsert = "(MY NIGGAS) ";
        int position = 6;

        string result = original.Insert(position, toInsert);

        Console.WriteLine(result);
    }
}
