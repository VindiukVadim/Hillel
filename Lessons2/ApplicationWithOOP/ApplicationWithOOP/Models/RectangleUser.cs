using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationWithOOP.Models
{
    internal class RectangleUser : Shape
    {
        private double _width;
        private double _height;

        public RectangleUser(string name, double width, double height) : base(name, true)
        {
            _width = width;
            _height = height;
        }

        public double Width
        {
            get { return _width; }
            set { _width = value; }
        }

        public double Height
        {
            get { return _height; }
            set { _height = value; }
        }

        public override double GetArea()
        {
            return _width * _height;
        }

        public override double GetPerimeter()
        {
            return 2 * (_width + _height);
        }

        public void Resize(double width, double height)
        {
            _width = width;
            _height = height;
        }

    }
}
