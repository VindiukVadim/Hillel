namespace Threads
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.Metrics;
    using System.IO;
    using System.Threading;

    class Program
    {
        static int[] numbers = new int[100000];
        static Dictionary<int, Dictionary<int,int>> results = new Dictionary<int, Dictionary<int, int>>();
        static object lockObject = new object();

        static void Main(string[] args)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = i + 1;
            }

            int numThreads = 4;
            Thread[] threads = new Thread[numThreads];


            for (int i = 0; i < numThreads; i++)
            {
                Console.WriteLine($"Enter an initial value for {i+1} thread");
                int from = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Enter the final value for {i+1} stream");              
                int to = Convert.ToInt32(Console.ReadLine());
                threads[i] = new Thread(() => FindSquareRoots(from, to, i));
                threads[i].Start();
            }

            foreach (Thread thread in threads)
            {
                thread.Join();
            }

            Console.WriteLine("Results:");
            foreach (var outerKey in results.Keys)
            {
                Console.WriteLine($"Thread {outerKey}:");
                foreach (var innerKey in results[outerKey].Keys)
                {
                    int value = results[outerKey][innerKey];
                    Console.WriteLine($"  {innerKey}: {value}");
                }
            }
        }

        static void FindSquareRoots(int from, int to, int t)
        {
            var innerResult = new Dictionary<int, int>();
            for (int i = from; i < to; i++)
            {
                 var sqrt = Math.Sqrt(numbers[i]);
                if ( sqrt% 1 == 0)
                {
                    lock (lockObject)
                    {
                        innerResult.Add(numbers[i], Convert.ToInt32(sqrt) );
                        
                    }
                }
            }
            results.Add(t, innerResult);
        }
    }

}

