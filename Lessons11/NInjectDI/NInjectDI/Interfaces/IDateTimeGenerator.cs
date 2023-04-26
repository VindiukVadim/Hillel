using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NInjectDI.Interfaces
{
    public interface IDateTimeGenerator
    {
        public string GetCurrentDateTime();
        public string GetRandomDateTіme();
    }
}
