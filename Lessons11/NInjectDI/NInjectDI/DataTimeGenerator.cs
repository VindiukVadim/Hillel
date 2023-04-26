using NInjectDI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NInjectDI
{
    internal class DataTimeGenerator : IDateTimeGenerator
    {
        public string GetCurrentDateTime()
        {
            var Date = DateTime.Now.ToString();
            return Date;
        }

        public string GetRandomDateTіme()
        {
           var rand = new Random();
           var Date =  new DateTime(rand.Next(2000, 2050), rand.Next(1, 13), rand.Next(1, 29)).ToString();
           return Date;
        }
    }
}
