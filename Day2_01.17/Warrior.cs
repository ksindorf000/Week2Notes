using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_01._17
{
    /*
    ------ Enumerator -------
    Keep track of the state of a class instance

    */

    enum State
    {
        Alive, Dead, Graveyard, Revived
    }

    class Warrior
    {
        //Class Members
        private int lifePts;
        public string name;
        private int attPts = 3;
        public State currentState = State.Alive;

        //Constructor
        public Warrior(string _name)
        {
            name = _name;
            lifePts = 10;
        }

        //Lower Life Points
        public void LowerLP()
        {
            if (lifePts <= attPts)
            {
                Console.WriteLine($"{name} is dead!");
                lifePts = 0;
                currentState = State.Dead;
            }
            else
            {
                lifePts -= attPts;
            }
        }

        public void Attack(Warrior enemy)
        {
            Console.WriteLine($"{name} attacks {enemy.name}!");
            enemy.LowerLP();

        }

        public override string ToString()
        {
            return $"{name}: {lifePts}";
        }

    }
}
