using System;
using System.Threading;


class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the range of numbers to print (start and end):");
        int begin = int.Parse(Console.ReadLine());
        int end = int.Parse(Console.ReadLine());
        Console.WriteLine("Please enter the amount of threads to use:");
        int threadCount = int.Parse(Console.ReadLine());
        void PrintNumberBegEn()
        {
            int rangeSize = (end - begin + 1) / threadCount;
            for (int t = 0; t < threadCount; t++)
            {
                int localStart = begin + t * rangeSize;
                int localEnd = localStart + rangeSize - 1;

                if (t == threadCount - 1)
                {
                    localEnd = end;
                }

                Thread thread = new Thread(() =>
                {
                    for (int i = localStart; i <= localEnd; i++)
                    {
                        Console.WriteLine(i);
                    }
                });

                thread.Start();
            }
        }
        Thread thread1 = new Thread(PrintNumberBegEn);
        thread1.Start();
    }
}
