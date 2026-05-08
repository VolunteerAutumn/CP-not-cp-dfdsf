using System;
using System.Threading;


class Program
{
    static void Main()
    {
        Random rnd = new Random();
        int[] ints = new int[10000];
        for (int i = 0; i <= 10000; i++)
        {
            ints[i] = rnd.Next(1, 100000);
        }
        void FindMax(int[] arr)
        {
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine("Max: " + max);
        }
        void FindMin(int[] arr)
        {
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("Min: " + min);
        }
        void Average(int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine("Average: " + (sum / arr.Length));
        }

        Thread max = new Thread(() => FindMax(ints));
        Thread min = new Thread(() => FindMin(ints));
        Thread avg = new Thread(() => Average(ints));

        max.Start();
        min.Start();
        avg.Start();
    }
}
