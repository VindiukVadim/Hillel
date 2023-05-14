using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Method.Models
{
    public class Town
    {
        public string Name { get; set; }
        public int Population { get; set; }
        public DateOnly FoundingDate { get; set; }
        public Country Country { get; set; }
    }
}
