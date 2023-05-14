using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.Models
{
    public class Product
    {
        public Guid Id { get; set;}
        public string Name { get; set;}
        public ICollection<Shop> Shops { get; set; }

    }
}
