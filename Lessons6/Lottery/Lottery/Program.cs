namespace Lottery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Введіть кількість розіграшів, наприклад 10, 50, 100 або інше число
            Console.WriteLine("Enter count of draws: ");
            var drawsCount = Convert.ToInt32(Console.ReadLine());
            //Введіть загальну кількість чисел в одному розіграші
            Console.WriteLine("Enter total count of numbers in one draws: ");
            var totalNumbers = Convert.ToInt32(Console.ReadLine());
            //Введіть кількість чисел, скільки потрібно вибрати в одному розіграші
            Console.WriteLine("Enter how many numbers to choose in one draw: ");
            var numbers = Convert.ToInt32(Console.ReadLine());
            //Введіть кількість найпопулярніших чисел які зустрічаються в розіграшах
            Console.WriteLine("Enter the count of most popular: ");
            var n = Convert.ToInt32(Console.ReadLine());

            var draws = new List<List<int>>();
            for (int i = 0; i < drawsCount; i++)
            {
                var list = Lottery.Emit(totalNumbers, numbers);
                draws.Add(list);
            }

            var numbersInDrawsNewerSelected = StatOperations.NeverAppeared(draws, numbers, totalNumbers);
            var numbersMostCommon = StatOperations.MostAppeared(draws, numbers, totalNumbers,n);
            Console.WriteLine("Never selected numbers:");
            numbersInDrawsNewerSelected.ForEach(draw => { Console.WriteLine($" number {draw}"); });
            Console.WriteLine("Most selected numbers:");
            foreach (var item in numbersMostCommon)
            {
                Console.WriteLine($"number: {item.Key}  total selected: {item.Value}");
            }
            Console.ReadLine();
        }

        public static class Lottery
        {
            public static List<int> Emit(int totalNumbers, int numbers)
            {
                var allNumbers = Enumerable.Range(1, totalNumbers).ToList();
                var random = new Random();
                var result = new List<int>();
                for (int i = 0; i < numbers; i++)
                {
                    int index = random.Next(0, allNumbers.Count);
                    result.Add(allNumbers[index]);
                    allNumbers.RemoveAt(index);
                }
                return result;
            }
        }

        public static class StatOperations
        {
            public static List<int> NeverAppeared(List<List<int>> draws, int numbers, int totalNumbers)
            {
                var allNumbers = Enumerable.Range(1, totalNumbers).ToList();
                var listSelectedNumbers = new List<int>();

                foreach (var draw in draws)
                {
                    foreach (var number in draw)
                    {
                        listSelectedNumbers.Add(number);
                    }
                }

                var hashList = new HashSet<int>(listSelectedNumbers);
                var list = allNumbers.Where(n => !hashList.Contains(n)).ToList();
                return list;

            }

            public static Dictionary<int,int> MostAppeared(List<List<int>> draws, int numbers, int totalNumbers,int n)
            {
                var listSelectedNumbers = new List<int>();
                var list = new Dictionary<int, int>();
                foreach (var draw in draws)
                {
                    foreach (var number in draw)
                    {
                        listSelectedNumbers.Add(number);
                    }
                }
                //var counts = listSelectedNumbers.GroupBy(n => n).ToDictionary(g => g.Key, g => g.Count());
                //counts.OrderByDescending(c => c.Value).Take(n);
                //return counts;

                var counts = listSelectedNumbers.GroupBy(n => n).ToDictionary(g => g.Key, g => g.Count());
                var sortedCounts = counts.OrderByDescending(c => c.Value).Take(n);
                var result = sortedCounts.ToDictionary(c => c.Key, c => c.Value);
                return result;
            }
        }

    }
}