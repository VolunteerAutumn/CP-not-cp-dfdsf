using System;
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();

        while (true)
        {
            string word = Console.ReadLine();

            if (word.EndsWith("."))
            {
                sb.Append(word);
                break;
            }

            sb.Append(word + ", ");
        }

        Console.WriteLine(sb.ToString());
    }
}
