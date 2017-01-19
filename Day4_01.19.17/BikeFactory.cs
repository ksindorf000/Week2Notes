using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_01._19._17
{
   /*
    * -------- FACTORY -------- 
    * 
    * Keeps things clean in Main()
    * 
    * Diff btw static and instance methods (11:00AM)
    */

    public class BikeFactory
    {
        
        //"Slight of Code" (11:25AM)
        public static List<Bike> CreateBikeList(int count)
        {
            var bikeList = new List<Bike>();
            var rng = new Random();


            for (int i = 0; i < count; i++)
            {
                CreateBike(bikeList, rng);
            }

            return bikeList;
        }

        private static void CreateBike(List<Bike> bikeList, Random rng)
        {
            bool isRandBike = rng.Next(10) < 4; //40% of bikes should be random

            if (isRandBike)
            {
                //Can't pass double so 8/10 = .8 and 13/10 = 1.3
                double speedModifier = (rng.Next(8, 13) / 10);
                int speedLimit = rng.Next(7, 20);

                bikeList.Add(new Bike(speedModifier, speedLimit));
            }
            else
            {
                bikeList.Add(new Bike());
            }
        }
    }
}
