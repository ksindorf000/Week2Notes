using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_01._18
{
    class Circle : Shape
    {
        //Constructor : inherited constructor
        public Circle(double _radius) : base(_radius)
        {
        }

        public override double CalcArea()
        {
            return Math.Pow(radius, 2) * Math.PI;
        }
    }

}
