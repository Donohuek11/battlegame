using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace battlegame
{
    class Program
    {
        static void Main(string[] args)
        {
            warrior kyle = new warrior
                ("Kyle", 1000, 120, 40);

            warrior mike = new warrior
                ("mike", 1000, 120, 40);
          
            battle.StartFight(kyle, mike);




            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
