using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationWithOOP.Models
{
    public abstract class Shape
    {
        private string _name;
        private bool _is2D;

        public Shape(string name, bool is2D)
        {
            _name = name;
            _is2D = is2D;
        }

        public string Name
        {
            get { return _name; }
        }

        public bool Is2D
        {
            get { return _is2D; }
        }

        public abstract double GetArea();

        public abstract double GetPerimeter();

    }
}
