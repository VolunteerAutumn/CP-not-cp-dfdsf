using System;

class Program
{
    static void Main()
    {
        string text = "   Hello   world   this   is   Sylveon   Speaking     lmfao       ";

        string[] words = text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

        string result = string.Join("*", words);

        Console.WriteLine(result);
    }
}

// ts was NOT fun to make NOT lol
