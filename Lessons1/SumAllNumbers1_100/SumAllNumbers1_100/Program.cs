namespace SumAllNumbers1_100
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum=0;
            Console.Clear();
            Console.WriteLine("Lektion #1. Learning GIT");
            for(var i=1; i<=100; i++) 
            {
                 sum += i;
            }
            Console.WriteLine("sum of all numbers with 1 to 100 = " + sum);
            Console.ReadLine();
        }
    }
}