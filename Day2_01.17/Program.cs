﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_01._17
{
    /*******************************
     * OBJECT ORIENTED PROGRAMMING *
     *******************************/
    /* 
     * C => C++ => C#
     * C++ language: First object oriented programming language 
     * 
     * "Encapsulating Logic"
     
     -------- SOLID PRINCIPLES OF OOP -------- 
     * 1) Single Responsibility Principle
     *      A class should only have "responsibilities" that make
     *      sense for their objects
     *          ex) You have two classes, "Dog" and "Car." A dog should
     *          not be able to make a car go faster and a car should not 
     *          be able to bark.
     * 2) Open/Closed
     * 3) Liskov Substitution
     * 4) I
     * 5) D
     * 
     */

    class Program
    {
        static void Main(string[] args)
        {
            /*
            DogStuff(); 
            ------ Extract Method ------
            // 1)Select block of code to make into method
            // 2)Right-click
            // 3)Select "Quick Actions and Refactoring"
            // 4)Select Extract Method
            // 5)Press Enter
            // 6)Rename Method 
            */

            Warrior dirt = new Warrior("Dirt");
            Warrior soap = new Warrior("Soap");

            while (dirt.currentState == State.Alive && soap.currentState == State.Alive)
            {
                Console.Clear();
                soap.Attack(dirt);
                Console.WriteLine("\n");
                Console.WriteLine(dirt);
                Console.WriteLine(soap);
                Console.ReadLine();
            }

        }

        private static void DogStuff()
        {
            var rascal = new Dog("Rascal"); //Good practice to use var just to easily 
                                            //see which variables are being set from another class
            Console.WriteLine(rascal); //Overriding ToString allows us to use this instead of 
                                       //Console.WriteLine(rascal.name);

            //Birthday() isn't accessible except to the Dog instance
            rascal.Birthday();
            rascal.Birthday();
            rascal.Birthday();
            rascal.Birthday();

            var age = rascal.GetAge();
            Console.WriteLine(age);

            var dogYears = rascal.DogYears();
            Console.WriteLine(dogYears);

            Console.WriteLine(rascal);

            Dog luke = new Dog("Luke");
            Dog trixie = new Dog("Trixie");
            Dog annie = new Dog("Annie");

            rascal.AddFriend(luke);
            rascal.AddFriend(trixie);
            rascal.AddFriend(annie);
            rascal.AddFriend(annie);

            luke.Birthday();

            rascal.GetDogFriends();

            rascal.RemoveFriend(annie);

            rascal.GetDogFriends();
        }
    }

    /******************************
    *           HOMEWORK          *
    *******************************/

    /*
     * Create a class and interact with it.
     *      ex) Model what it looks like to attend TIY
     *          Model what it looks like to learn to swim
     */
}
