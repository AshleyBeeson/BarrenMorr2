using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barrenmoor
{
    //TODO: ADD a 'second' dial to point to the closest event 
    class Compass
    {

        public static float Dist { get; set; }
        public static float NearestEvent { get; set; }

        internal static void GetDistance(Position pos, Point point)
        {
            
            int playerX = pos.X;
            int playerY = pos.Y;

            int specialX = point.pos.X;
            int specialY = point.pos.Y;

            float opp = specialX - playerX;
            float adj = specialY - playerY;

            Dist = (float)(Math.Pow(opp,2) + Math.Pow(adj,2));

            //Console.WriteLine(string.Format("opp: {0}, adj: {1}, Dist: {2}", opp, adj, Dist));

        }

        internal static void FindNearestEvent(Position pos, List<Point> eventPoints)
        {
            int playerX = pos.X;
            int playerY = pos.Y;

            Point closestPoint = new Point(new Position(10000000,100000000),EventType.Trap);

            foreach (var point in eventPoints)
            {
                if (point.type == EventType.Special)
                {
                    continue;
                }
                //Get points coords    
                int x = point.pos.X;
                int y = point.pos.Y;

                //Calculate distance from player
                int deltaX = x - playerX;
                int deltaY = y - playerY;

                //Check for isClosest
                if (deltaX < closestPoint.pos.X && deltaY < closestPoint.pos.Y)
                {
                    closestPoint = point;
                }
            }

            int specialX = closestPoint.pos.X;
            int specialY = closestPoint.pos.Y;

            float opp = specialX - playerX;
            float adj = specialY - playerY;

            NearestEvent = (float)(Math.Pow(opp, 2) + Math.Pow(adj, 2));

        }
    }
}
