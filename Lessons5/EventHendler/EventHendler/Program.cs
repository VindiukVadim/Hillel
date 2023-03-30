namespace EventHendler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var numbers = new double[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var handler = new ArrayHandler(numbers);

            handler.IntegerRootFound += (sender, root) =>
            {
                Console.WriteLine($"Integer root found: {root}");
            };

            var filteredRoots = handler.SquareRoots(number => number > 3 && number < 8);
            foreach (var root in filteredRoots)
            {
                Console.WriteLine($"Filtered root: {root}");
            }

            var list = new List<int>(); 
            list.Add(1);
            list.Add(2);    
            list.Add(3);    
            list.Add(1);

            var hash = new HashSet<int>(list);

            foreach (var root in list)
            {
                Console.WriteLine(root.ToString());
            }
            Console.WriteLine("--------------------");
            foreach (var root in hash)
            {
                Console.WriteLine(root.ToString());
            }

            foreach (var item in list)
            {
                Console.WriteLine(item.ToString());
                list.Remove(item);
            }    

            

        }
    }
}