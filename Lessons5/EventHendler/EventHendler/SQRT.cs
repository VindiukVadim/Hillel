using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegat
{
    public static class SQRT
    {
        public static double Extension(double x)
        {
            var result = Math.Sqrt(x);
            return result;   
        }

    }
}
