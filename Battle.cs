using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barrenmoor
{
    class Battle
    {
        //Add level scaling
        //Add level proportional to treasure and battles
        //Add monster flavour text
        public bool battle(int playerHp, int playerAtk, int x, int y)
        {
            //new battle flavour text
            Random rnd = new Random();
            int monsterHp = 10 + rnd.Next(-10,x+y), monsterAtk = 5 + rnd.Next(-5,x+y);
            Console.WriteLine("Player Health: " + playerHp);
            Console.WriteLine("Player Attack: " + playerAtk);
            Console.WriteLine("Monster Health: " + monsterHp);
            Console.WriteLine("Monster Attack: " + monsterAtk);
            int battleHp = playerHp;
            bool death = false;
            while(battleHp > 0 && monsterHp > 0)
            {
                battleHp -= monsterAtk;
                monsterHp -= playerAtk;
                if (battleHp <= 0)
                {
                    death = true;
                    Console.WriteLine("You died! That is not good.");
                }
                else if (battleHp > 0 & monsterHp <= 0)
                {
                    Console.WriteLine("You won! How glorious!");
                }
            }
            return death;
        }
    }
}
