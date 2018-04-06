using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barrenmoor
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            MapClass map = new MapClass();
            Treasure treasure = new Treasure();
            Battle btl = new Battle();
            Random rnd = new Random();
            treasure.RandomTreasurePosition();
            bool isDead = false;

            int points = 0;
            bool treasurePointsMet = false;
            player.IntroTxt(); 

            while ( (isDead==false) && (treasurePointsMet == false) )
            {
 
                Console.WriteLine("Please input North, East, South or West");
                string move = Console.ReadLine();
                player.MovePosition(move);
                double dist = map.TreasureDist(player.GetX(), player.GetY(), treasure.GetX(), treasure.GetY());
                Console.WriteLine("-------------------------------");
                Console.WriteLine("You are " + dist + " away bro");
                Console.WriteLine("-------------------------------");

                if (dist == 0)
                {
                    treasure.RandomTreasurePosition();
                    points = points + treasure.DetermineTreasureLevel();
                    player.SetHP(player.GetHP() + points);
                    player.SetAtk(player.GetAtk() + points);
                    Console.WriteLine("You have " + points + "points");
                }
                else
                {
                    if (rnd.Next(0, 4) == 3)
                    {
                        isDead = btl.battle(player.GetHP(), player.GetAtk(), player.GetX(), player.GetY());
                        if (isDead == true)
                        {
                            Console.WriteLine("You struggle to breathe your last... cold... breath... but fail.");
                            Console.ReadLine();
                        }
                    }
                }
                if (points >= 50) treasurePointsMet = true;

                if (treasurePointsMet)
                {
                    Console.WriteLine("Yh m8 you winz0");
                    //treasureFound = true;
                    Console.ReadLine();
                }
            }
        }

    }
}
