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
        int playerHp = 10;   //Player.GetHp();
        int playerAtk = 5;    //Player.GetAtk();
        int playerLvl = 1;  //Player.GetLvl();
        int monsterHp = 10; //Monster.GetHp();
        int monsterAtk = 5; //Monster.GetAtk();
        public bool battle(int playerHp, int playerAtk, int playerLvl)
        {
            //new battle flavour text
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
