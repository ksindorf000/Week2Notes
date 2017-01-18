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
         * 
         * 1) S ingle Responsibility Principle
         *      A class should only have "responsibilities" that make
         *      sense for their objects
         *          ex) You have two classes, "Dog" and "Car." A dog should
         *          not be able to make a car go faster and a car should not 
         *          be able to bark.
         * 2) O pen/Closed http://joelabrahamsson.com/a-simple-example-of-the-openclosed-principle/
         *      Open for extension
         *          Use Overrides, Overloads, & Sub Classes
         *      Closed for modification
         * 3) L
         * 4) I
         * 5) D
         * */

        /*
         * -------- UNIT TESTING -------- 
         * 
         * Testing will slow you down at first but, once you get comfortable,
         * they will speed up the development process overall
         * 
         *          Project 1               Project 2
         *      -------------------     -------------------    
         *      | Day 3           |     | Day 3           |
         *      | "Shapes"        |     | "Tests"         |
         *      -------------------     -------------------
         *      -Circle                 Reference to "Day3_Shapes" 
         *      -Square                     - Solution Explorer
         *      -Shape                      - Project > References > Add Reference
         *          -Area                 --------------------
         *          -Height               -Does x.area compute?
         *          -Width                -Does circle.area compute?
         *          -Radius               -Does square.area compute?
         *                                  ^These three tests are called a harness
         *                                  
         * Referenced classes must be public
         * Include "Using <ProjectName>;"
         * 
         * How many tests are the right number of tests?
         *      There is no right answer
         *      Learning what to test takes time
         */


        static void Main(string[] args)
        {
            var square = new Square(2, 5);
            double sqArea = square.CalcArea();
            Console.WriteLine(sqArea);

            Shape circle = new Circle(12); 
            double circArea = circle.CalcArea();
            Console.WriteLine(circArea);

            //Shape doesn't exist but the virtual CalcArea() in Shape class returns 0
            var nanogram = new Shape();
            double nanoArea = nanogram.CalcArea();
        }

        /*
         * -------- HOMEWORK -------- 
         * Currency Converter
         * Pass in a value and a symbol and return as different currencies
         *      HINT: Operator Overloading
         *      
         */


    }
}
