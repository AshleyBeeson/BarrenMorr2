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
                Console.WriteLine("You are " + dist + " away bro");

                if ( dist == 0)
                {
                    treasure.RandomTreasurePosition();
                    treasure.DetermineTreasureLevel();
                    points = points + treasure.GetTreasurePoints();
                    Console.WriteLine("You have " + points + "points");
                }

                if (points >= 50) treasurePointsMet = true;

                if (treasurePointsMet)
                {
                    player.treasuretxt();
                    Console.WriteLine("Yh m8 you winz0");
                    //treasureFound = true;
                    Console.ReadLine();
                }
            }
        }

    }
}
