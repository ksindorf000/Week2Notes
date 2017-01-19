using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4_01._19._17
{
    public class Bike
    {
        private int speed = 0;
        private double speedModifier = 1;
        public int speedLimit = 12;
        public int location = 0;

        public Bike()
        {
        }

        public int GetSpeed()
        {
            return speed;
        }

        public double GetModifier()
        {
            return speedModifier;
        }

        public void Accelerate()
        {
            if (speed < speedLimit)
            {
                speed++;
            }
        }

        public void MoveForward()
        {
            location += speed; //"In-Place Addition" (10:14AM)
        }

    }
}
