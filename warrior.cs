using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace battlegame
{
    class warrior
    {

        // name health attack maximum block maximum
        public string Name { get; set; } = "Warrior";
        public double Health { get; set; } = 0;
        public double AttackMax { get; set; } = 0;
        public double BlockMax { get; set; } = 0;

        // random numbers 
        Random rnd = new Random();

        public warrior(string name = "Warrior", double health = 0,
            double attkMax = 0, double blockMax = 0)
        {
            Name = name;
            Health = health;
            AttackMax = attkMax;
            BlockMax = blockMax;
        }

     //attack
    //generate a random attack from 1 to the max attack
    public double Attack()
        {
            return rnd.Next(1, (int)AttackMax);
        }


        //block, generate random block from 1 to max block

        public double Block()
        {
            return rnd.Next(1, (int)BlockMax);
        }

    }
}
