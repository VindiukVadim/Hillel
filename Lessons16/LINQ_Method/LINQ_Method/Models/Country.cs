using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Method.Models
{
    public class Country
    {
        public string Name { get; set; }    
        public string Mainland { get; set; }
        public Town Capital { get; set; }
        public List<Town> Towns { get; set; }
    }
}
