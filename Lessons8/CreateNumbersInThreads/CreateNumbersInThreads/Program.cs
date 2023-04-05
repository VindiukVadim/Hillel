using System.Diagnostics.Tracing;

namespace CreateNumbersInThreads
{
    internal class Program
    {
        static int evenCounter = 0;
        static int notEvenCounter = 0;
        static readonly object lockObject = new object();
        static void Main(string[] args)
        {
            Thread[] threads = new Thread[10];

            for (int i = 0; i < threads.Length; i++)
            {
                threads[i] = new Thread(new ThreadStart(GenerateRandomNumbers));
                threads[i].Start();
            }

            for (int i = 0; i < threads.Length; i++)
            {
                threads[i].Join();
            }

            Console.WriteLine($"even numbers: {evenCounter}");
            Console.WriteLine($"not even numbers: {notEvenCounter}");
        }

        static void GenerateRandomNumbers()
        {
            Random rnd = new Random();

            for (int i = 0; i < 10; i++)
            {
                int randomNumber = rnd.Next(1, 101);

                lock (lockObject)
                {
                    if (randomNumber % 2 == 0)
                    {
                        evenCounter++;
                    }
                    else
                    {
                        notEvenCounter++;
                    }
                }
            }
        }
    }


}