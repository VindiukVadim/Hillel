using Computer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer.Models
{
    internal class HardDrive:IHardDrive
    {
        public HardDrive(string name, string MemorySize)
        {
            this.Name = name;
            this.MemorySize = MemorySize;
        }
        public string Name { get; set; }
        public string MemorySize { get; set; }

        public void Remove()
        {
            Console.WriteLine("Hard Drive is Removed");

        }
    }
}
