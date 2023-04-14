namespace ManualResetEvent1
{
    internal class Program
    {
        static ManualResetEvent autoResetEvent= new ManualResetEvent(false);
        static int[] arr = new int[100000];
        static bool negativ = false;
        static void Main(string[] args)
        {

            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
                arr[i] = rand.Next(1,20);


           

            Thread[] threads = new Thread[5];

            for (int i = 0; i < threads.Length-1; i++)
            {
                threads[i] = new Thread(Sum);
                
            }
            threads[4] = new Thread(FindNegative);

            for (int i = 0; i < threads.Length; i++)
            {
                threads[i].Start();
            }

            for (int i = 0; i < threads.Length; i++)
            {
                threads[i].Join();
            }
        }

        static void FindNegative()
        {
            foreach(var el in arr)
            {
                if (el < 0)
                {
                    negativ= true;
                    Console.WriteLine("Find negativ element");
                    break;
                    
                } 
            }
            Console.WriteLine("Didn`t find negativ element");
            autoResetEvent.Set();
        }

        static void Sum()
        {
            autoResetEvent.WaitOne();
            int index = 0;
            int start = (arr.Length / 4) * index;
            int end = (arr.Length / 4) * (index + 1);
            int sum = 0;
            for (int i = start; i < end; i++)
            {
                sum += arr[i];
            }
            index = index + 1;
            Console.WriteLine("Thread {0}: Sum = {1}", index, sum);
            
        }
    }
}