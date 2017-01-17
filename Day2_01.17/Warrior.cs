using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_01._17
{
    /*
         ------ Enumerator -------
         * 
        */
    enum State
    {
        Alive, Dead, Graveyard, Revived
    }

    class Warrior
    {
        private int hitPts;
        public string name;
        private bool playOn = true;
        private int attPts = 3;
        public State currentState = State.Alive;
        

        //Constructor
        public Warrior (string _name)
        {
            name = _name;
            hitPts = 10;
        }

        public void LowerHP()
        {
            if (hitPts <= attPts)
            {
                Console.WriteLine($"{name} is dead!");
                hitPts = 0;
                currentState = State.Dead;
            }
            else
            {
                hitPts -= attPts;
            }
        }

        public void Attack(Warrior enemy)
        {
            Console.WriteLine($"{name} attacks {enemy.name}!");
            enemy.LowerHP();
          
        }

        public override string ToString()
        {
            return $"{name}: {hitPts}";
        }

    }
}
