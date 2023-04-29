using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialaze.Models
{
    [Serializable]
    public class Car
    {
        public int Id { get; set; }
        public string Brend { get; set; }
        public int MaxSpeed { get; set; }
        public string Color { get; set; }
        public Car()
        {
            Id = 1;
            Brend = "Mercedes";
            MaxSpeed= 200;
            Color = "Red";
        }

    }
}
