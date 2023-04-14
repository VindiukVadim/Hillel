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
        public event EventHandler MyEvent;
        public ArrayHandler(double[] num)
        {
            numbers = num;
        }

        public IEnumerable<double> SquareRoots(Func<double,bool> func)
        {
            foreach (var item in numbers)
            {
                var result = SQRT.Extension(item);
                if (func(result))
                {
                    var args = new Arguments{ number = item };
                    OnMyEvent(args);
                    yield return result;
                }
                
            }
            
        }


        private void OnMyEvent(Arguments args)
        {
            MyEvent?.Invoke(this, args);

        }
    }

    public class Arguments : EventArgs
    {
        public double number { get; set; }
    }
}
