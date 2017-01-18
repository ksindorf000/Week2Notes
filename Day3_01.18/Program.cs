using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3_01._18
{
    class Program
    {
        /*
         * -------- SOLID PRINCIPLES OF OOP -------- 
         * 1) S ingle Responsibility Principle
         *      A class should only have "responsibilities" that make
         *      sense for their objects
         *          ex) You have two classes, "Dog" and "Car." A dog should
         *          not be able to make a car go faster and a car should not 
         *          be able to bark.
         * 2) O pen/Closed http://joelabrahamsson.com/a-simple-example-of-the-openclosed-principle/
         *      Open for extension
         *      Closed for modification
         * 3) L
         * 4) I
         * 5) D
         * */

        /*
         * 
         */


        static void Main(string[] args)
        {
            var square = new Square(2, 5);
            double sqArea = square.CalcArea();
            Console.WriteLine(sqArea);

            var circle = new Circle(12);
            double circArea = circle.CalcArea();
            Console.WriteLine(circArea);

            //Shape doesn't exist but the virtual CalcArea() in Shape class returns 0
            var nanogram = new Shape();
            double nanoArea = nanogram.CalcArea();
        }
    }
}
