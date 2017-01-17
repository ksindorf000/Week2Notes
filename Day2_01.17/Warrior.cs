using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_01._17
{
    class Warrior
    {
        private int hitPts;
        public string name;

        //Constructor
        public Warrior (string _name)
        {
            name = _name;
            hitPts = 10;
        }

        public void LowerHP()
        {
            hitPts -= 3;
        }

        public void Attack(Warrior enemy, Warrior attacker)
        {
            Console.WriteLine($"{attacker} attacks {enemy}!");
            enemy.LowerHP();
            Console.WriteLine($"{enemy.name} now has {enemy.hitPts} life points! \n");
        }

        public override string ToString()
        {
            return $"{name}: {hitPts}";
        }

    }
}
