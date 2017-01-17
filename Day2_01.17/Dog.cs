using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_01._17
{

    /*
     *  Class: the blueprint for the object, same behaviors as types like strings and ints
     *      Dog
     *  Object: the instance created by the Class =
     *      rascal (created in Main())
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
     *  Access Modifiers = 
     *      public: Read/Write available to other classes
     *      private: Read/Write only in current class
     *      protected
     *      sealed
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
        public List<Dog> friends = new List<Dog>();

        //Constructor
        //      doesn't have a return type
        public Dog(string _name) //use "_" to avoid name collision
        {
            Age = 0;
            name = _name;
        }

        //Method
        //      Age*7 to get age in "dog years"
        public int DogYears()
        {
            return Age *= 7;
        }

        //Method
        //      Adds a year to Dog's Age
        public void Birthday()
        {
            Age++;
        }

        //Method
        //      Displays friends<>
        public void GetDogFriends()
        {
            Console.WriteLine(string.Join(", ", friends));
        }

        //Method
        //      Adds a friend to friends<>
        public void AddFriend(Dog friend)
        {
            if (friends.Contains(friend))
            {
                Console.WriteLine($"{friend} is already a friend!");
            }
            else
            {
                friends.Add(friend);
            }
        }

        //Method
        //      Removes a friend from friends<>
        public void RemoveFriend(Dog friend)
        {
            friends.Remove(friend);
        }

        /*
        -------- Override ToString() -------- 
        * ToString() is the method called when you try to cw an object
        * By overriding the method, you can tell it exactly 
        * what you want it to return
        */
        public override string ToString()
        {
            return $"{name}: {Age}";
        }

        //Accessor Method for private variable
        public int GetAge()
        {
            return Age;
        }

        //Shorter syntax for accessor method:


    }
}
