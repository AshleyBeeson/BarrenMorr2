using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Barrenmoor
{
    class CombatLoop
    {
        
        private static int combatTime = 1500;

        public static void Fight(NPC monster, Player player)
        {
            int count = combatTime;
            Console.WriteLine("A struggle ensues between you and the " + monster.Name);
            
            while (player.Health > 0 && monster.Health > 0)
            {

               Thread.Sleep(combatTime);
               Console.WriteLine("The Struggle Continues...");
               monster.Health -= (player.attack - monster.defense);
               player.Health -= (monster.attack - player.defense);
                
            }

            if (player.Health <= 0)
            {
                Console.WriteLine("After a valiant effort you were defeated by a " + monster.Name);
                Console.WriteLine("What a shame");
                Console.Read();
                Environment.Exit(0);
            }
            if (monster.Health <= 0)
            {
                Console.WriteLine("After what felt like forever your struggle ends with the " + monster.Name + " Lying dead at your feet");
               
            }
        }

    }
}
