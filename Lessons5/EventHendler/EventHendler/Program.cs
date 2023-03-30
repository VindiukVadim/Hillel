using Delegat;

namespace EventHendler
{
    public delegate double Del(double x);
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] doubleNumbers = { 9, 23, 45, 56, 11, 0.5, 0.8, 1.6, 2.7, 3.6, 5.8, 6.4, 9.5 };
            var ArrayHandlerExeplar = new ArrayHandler(doubleNumbers);

            Del delegat = new Del(SQRT.Extension);

            var result = ArrayHandler.SquareRoots(delegat).Where(x => x > 5 || x % 1 == 0);

        }
    }
}