using System;

class Program
{
    static void Main()
    {
        string text = "My favorite pokemon is Sylveon and it is undeniable";
        int index = int.Parse(Console.ReadLine());

        string[] words = text.Split(' ');

        if (index >= 0 && index < words.Length)
        {
            Console.WriteLine(words[index][0]);
        }
    }
}
