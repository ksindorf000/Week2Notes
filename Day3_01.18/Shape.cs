using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_01._18
{
    class Shape
    {
        public double height;
        public double width;
        public double radius;

        public Shape() { } //Default Constructor still needed

        //----------Overload the constructor to allow a different set of parameters---------//

        //Circle Constructor
        public Shape(double _radius)
        {
            radius = _radius;
        }

        //Square Constructor
        public Shape(double _height, double _width)
        {
            height = _height;
            width = _width;
        }

        //virtual = subclasses can override this method
        public virtual double CalcArea()
        {
            return 0;
        }

    }
}
