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
            bool treasureFound = false;

            while (treasureFound==false)
            {
                Console.WriteLine("Please input North, East, South or West");
                string move = Console.ReadLine();
                player.MovePosition(move);
                double dist = map.TreasureDist(player.GetX(), player.GetY(), treasure.GetX(), treasure.GetY());
                Console.WriteLine("You are " + dist + " away bro");
                //Console.WriteLine(player.GetX());
                //Console.WriteLine(player.GetY());
                //Console.WriteLine(treasure.GetX());
                //Console.WriteLine(treasure.GetY());

                if (dist == 0)
                {
                    Console.WriteLine("Yh m8 you winz0");
                    treasureFound = true;
                } 
            }
        }

    }
}
