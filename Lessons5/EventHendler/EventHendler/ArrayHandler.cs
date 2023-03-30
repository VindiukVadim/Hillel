using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHendler
{

    public static class SquareRootCalculator
    {
        public static double Sqrt(this int number)
        {
            return Math.Sqrt(number);
        }

        public static double Sqrt(this double number)
        {
            return Math.Sqrt(number);
        }
    }

    public class ArrayHandler
    {
        private readonly List<double> _numbers;

        public delegate bool Filter(double number);

        public event EventHandler<int> IntegerRootFound;

        public ArrayHandler(IEnumerable<double> numbers)
        {
            _numbers = new List<double>(numbers);
        }

        public IEnumerable<double> SquareRoots(Filter filter)
        {
            foreach (var number in _numbers)
            {
                 var root = number.Sqrt();

                if (root % 1 == 0)
                {
                    IntegerRootFound?.Invoke(this, (int)root);
                }

                if (filter(number) && root > 5)
                {
                    yield return root;
                }
            }
        }
    }

}
