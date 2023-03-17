using Computer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer.Models
{
    public class RAM : IRAM
    {
        public RAM(string name, string MemorySize)
        { 
            this.Name = name;
            this.MemorySize = MemorySize;
        }
        public string MemorySize { get; set; }
        public string Name { get; set; }

        public void Eject()
        {
            Console.WriteLine("RAM is Ejected");
        }
    }
}
