using System;
using System.Threading;


class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the range of numbers to print (start and end):");
        int begin = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());
        void PrintNumber1_50()
        {
            for (int i = begin; i <= end; i++)
            {
                Console.WriteLine(i);
            }
        }
        Thread thread1 = new Thread(PrintNumber1_50);
        thread1.Start();
    }
}
