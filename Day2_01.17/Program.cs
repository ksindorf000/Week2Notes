using System;
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
         */

        /*
         * Class: the instructions for the object
         *  Access Modifiers = 
         *      public: Read/Write available to other classes
         *      private: Read/Write only in current class
         *      protected
         *      sealed
         *  Object = 
         *      Dog
         *  Properties/Variables/Attributes =
         *      int Age 
         *      float(..ing point number) Size
         *      string Color
         *  Methods = 
         *      Bark();
         *      WagTail();
         *      RollOver();
         *  Constructors = 
         *      methods that run when an object is created
         *      doesn't have a return type
         *          
         * Syntax:
         *  var dog = new Dog(); //new instance of Class Dog
         *  dog.age(get(), set());
         *  dog.Bark();
         *  
         */

    class Dog //Class definition
    {
        private int Age; //Property
        public string name; //Member

        //Constructor
        //      doesn't have a return type
        public Dog(string _name) //use "_" to avoid name collision
        {
            Age = 0;
            name = _name;
        }

        //Method
        public void Birthday()
        {
            Age++;
        }

        //Accessor Method for private variable
        public int GetAge()
        {
            return Age;
        }

        public int DogYears()
        {
            return Age *= 7;
        }

        //Shorter syntax for accessor method:
        

    }


    class Program
    {
        static void Main(string[] args)
        {
            var rascal = new Dog("Rascal"); //Good practice to use var just to easily 
                                            //see which variables are being set from another class
            Console.WriteLine(rascal.name);

            //Birthday() isn't accessible except to the Dog instance
            rascal.Birthday();
            rascal.Birthday();
            rascal.Birthday();
            rascal.Birthday();

            var age = rascal.GetAge();
            Console.WriteLine(age);

            var dogYears = rascal.DogYears();
            Console.WriteLine(dogYears);
        }
    }
}
