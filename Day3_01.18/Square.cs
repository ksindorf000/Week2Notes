using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_01._18
{
    public class Square : Shape
    {
        //Constructor : inherited constructor
        public Square(double _height, double _width) : base(_height, _width)
        {
        }

        public override double CalcArea()
        {
            return height * width;
        }
    }
}
