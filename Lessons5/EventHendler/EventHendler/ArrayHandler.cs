using EventHendler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Delegat
{
    
    public class ArrayHandler
    {
        static double[] numbers;
        public ArrayHandler(double[] num)
        {
            numbers = num;
        }

        public static IEnumerable<double> SquareRoots(Del Del)
        {
            foreach (var item in numbers)
            {
                yield return Del(item);
            }
            
        }
    }
}
