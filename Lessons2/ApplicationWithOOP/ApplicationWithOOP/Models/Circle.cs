using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationWithOOP.Models
{
    public class Circle : Shape
    {
        private double _radius;

        public Circle(string name, double radius) : base(name, true)
        {
            _radius = radius;
        }

        public double Radius
        {
            get { return _radius; }
            set
            {
                if (value <= 0)
                    Console.WriteLine("Radius must be >0");
                _radius = value;
            }
        }

        public override double GetArea()
        {
            return Math.PI * _radius * _radius;
        }

        public override double GetPerimeter()
        {
            return 2 * Math.PI * _radius;
        }


    }
}
