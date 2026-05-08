using System;
using System.Threading;


class Program
{
    static void Main()
    {
        void PrintNumber1_50()
        {
            for (int i = 1; i <= 50; i++)
            {
                Console.WriteLine(i);
            }
        }
        Thread thread1 = new Thread(PrintNumber1_50);
        thread1.Start();
    }
}
