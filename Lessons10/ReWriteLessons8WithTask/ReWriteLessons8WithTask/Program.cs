using System;
using System.Threading.Tasks;

namespace CreateNumbersInTasks
{
    internal class Program
    {
        static int evenCounter = 0;
        static int notEvenCounter = 0;
        static readonly object lockObject = new object();
        static async Task Main(string[] args)
        {
            Task[] tasks = new Task[10];

            for (int i = 0; i < tasks.Length; i++)
            {
                tasks[i] = GenerateRandomNumbersAsync();
            }

            await Task.WhenAll(tasks);

            Console.WriteLine($"even numbers: {evenCounter}");
            Console.WriteLine($"not even numbers: {notEvenCounter}");
        }

        static async Task GenerateRandomNumbersAsync()
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