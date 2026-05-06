using System;

class Program
{
    static void Main()
    {
        string input = Console.ReadLine();
        string reversed = "";

        for (int i = input.Length - 1; i >= 0; i--)
        {
            reversed += input[i];
        }

        if (input == reversed)
            Console.WriteLine("Palindrome");
        else
            Console.WriteLine("Not palindrome");
    }
}
