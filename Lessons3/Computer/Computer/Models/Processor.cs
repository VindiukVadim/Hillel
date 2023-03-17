using Computer.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Computer.Models
{
    internal class Processor : IProcessor
    {
        public Processor(string name, string frequency) 
        {
            this.Name = name;
            this.Frequency = frequency;
        }
        public string Name { get; set; }
        public string Frequency { get; set; }

        public void Unplug()
        {
            Console.WriteLine("Processor is unpluged");
        }
    }
}
