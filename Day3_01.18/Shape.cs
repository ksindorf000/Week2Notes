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
        public string shapeType;

        public Shape(double _height, double _width, double _radius, string _shapeType)
        {
            height = _height;
            width = _width;
            radius = _radius;
            shapeType = _shapeType;
        }

        public double CalcArea()
        {
            if (shapeType == "square")
            {
                return height * width;
            }
            else if (shapeType == "circle")
            {
                return Math.Pow(radius, 2) * Math.PI;
            }
            return 0;
        }

    }
}
