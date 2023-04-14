using Delegat;


namespace EventHendler
{

    internal class Program
    {
        static void Main(string[] args)
        {
            double[] doubleNumbers = { 36, 47, 61, 56, 11, 0.5, 0.8, 1.6, 2.7, 49, 5.8, 6.4, 64 };
            var arrayHandlerExemplar = new ArrayHandler(doubleNumbers);

            arrayHandlerExemplar.MyEvent += RunEvent;


            var result = arrayHandlerExemplar.SquareRoots(x => x % 1 == 0 && x > 5);

            foreach (var item in result)
            {
                Console.WriteLine($" SQRT - {item}");
            }

            Console.ReadLine();
        }

        public static void RunEvent(object sender, EventArgs e)
        {
            Arguments args = (Arguments)e;
            Console.WriteLine($"Find! - {args.number}");
        }
    }


}