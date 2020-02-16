using System;

namespace battlegame
{
    class battle
    {
   
    //startFight
    // warrior1 and warrior2
    public static void StartFight(warrior 
        warrior1, warrior warrior2)
        {
            while (true)
            {
                if(GetAttackResult(warrior1, warrior2) == "Game Over")
                {
                    Console.WriteLine("Game Over");
                    break;
                }
                if (GetAttackResult(warrior2, warrior1) == "Game Over")
                {
                    Console.WriteLine("Game Over");
                    break;
                }

            }
        }

    //loop giving each warrior a chance to attack and block each turn until one dies


    //getAttackResult - warriorA, WarriorB
    public static string GetAttackResult (warrior warriorA, warrior warriorB)
        {
            double warAAttkAmt = warriorA.Attack();
            double warBBlkAmt = warriorB.Block();

            double dmg2WarB = warAAttkAmt - warBBlkAmt;

            if(dmg2WarB > 0)
            {
                warriorB.Health = warriorB.Health - dmg2WarB;
                
            }else dmg2WarB = 0;

            Console.WriteLine("{0} Attacks {1} and Deals {2} Damage", warriorA.Name, warriorB.Name,
                dmg2WarB);

            Console.WriteLine("{0} Has {1} health \n", warriorB.Name, warriorB.Health);

            if (warriorB.Health <= 0)
            {
                Console.WriteLine("{0} has died and {1} is victorius\n", warriorB.Name, warriorA.Name);
                return "Game Over";

            }
            else return "Fight Again";
        
        }
    //Calculate 1 warriors attack and the others block

        //subtract block from attack

        //if there was damage, sub that damage from health of other waror

        //print out info on who attacked who and for how much damage

        //provide output on the change in health

        //check if the warriors health fell below zero and if so pring message and then send a response to end loop

    
    
    
    }
}
