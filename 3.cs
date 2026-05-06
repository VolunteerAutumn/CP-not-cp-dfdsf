using System;

class Program
{
    static void Main()
    {
        string text = Console.ReadLine();

        int lower = 0, upper = 0;
        int totalChars = text.Length;
        int totalLetters = 0;

        foreach (char c in text)
        {
            if (char.IsLetter(c))
            {
                totalLetters++;

                if (char.IsLower(c)) lower++;
                else if (char.IsUpper(c)) upper++;
            }
        }

        Console.WriteLine("=== Based on ALL characters ===");
        if (totalChars > 0)
        {
            Console.WriteLine($"Lowercase: {(double)lower / totalChars * 100:F2}%");
            Console.WriteLine($"Uppercase: {(double)upper / totalChars * 100:F2}%");
        }

        Console.WriteLine("\n=== Based ONLY on letters ===");
        if (totalLetters > 0)
        {
            Console.WriteLine($"Lowercase: {(double)lower / totalLetters * 100:F2}%");
            Console.WriteLine($"Uppercase: {(double)upper / totalLetters * 100:F2}%");
        }
        else
        {
            Console.WriteLine("No letters found.");
        }
    }
}
