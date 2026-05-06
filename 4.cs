using System;

class Program
{
    static void Main()
    {
        string[] words = { "hello", "world", "cat", "amazing" };
        int chosenLength = int.Parse(Console.ReadLine());

        for (int i = 0; i < words.Length; i++)
        {
            if (words[i].Length == chosenLength)
            {
                words[i] = words[i].Substring(0, words[i].Length - 3) + "$$$";
            }
        }

        Console.WriteLine(string.Join(" ", words));
    }
}

// ts was fun to make btw lol
