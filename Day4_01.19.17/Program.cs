using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_01._19._17
{
    public class Program
    {
        /*
        * -------- SOLID PRINCIPLES OF OOP -------- 
        * 
        * 1) S ingle Responsibility Principle
        *      A class should only have "responsibilities" that make
        *      sense for their objects
        *          ex) You have two classes, "Dog" and "Car." A dog should
        *      not be able to make a car go faster and a car should not
        *      be able to bark.
        * 2) O pen/Closed http://joelabrahamsson.com/a-simple-example-of-the-openclosed-principle/
        *      Open for extension
        *      Use Overrides, Overloads, & Sub Classes
        *      Closed for modification
        * 3) L iskov 
        *      A subclass can be replaced by it's parent 
        * 4) I nterface Segregation
        * 5) D ependency Inversion
        */

        static void Main(string[] args)
        {
            //(11:30AM)
            List<Bike> raceBikes = BikeFactory.CreateBikeList(4); //Since static, you don't have to create an instance
            int finishLine = 1000;
            bool isRunning = true;

            while (isRunning)
            {
                for (int i = 0; i < raceBikes.Count; i++)
                {
                    var currentBike = raceBikes[i];
                    isRunning = TickRace(currentBike, finishLine, isRunning);
                }
            }

            foreach (var bike in raceBikes)
            {
                Console.Write(string.Join(", ", bike.location));
            }

        }

        public static bool TickRace(Bike currentBike, int finishLine, bool isRunning)
        {
                if (currentBike.location >= finishLine)
                {
                    isRunning = false;
                }
                else
                {
                    currentBike.Accelerate();
                    currentBike.MoveForward();
                }

            return isRunning;
        }
        

    }
}
