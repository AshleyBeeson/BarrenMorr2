using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barrenmoor
{
    class Compass
    {

        public static float Dist { get; set; }

        internal static void GetDistance(Position pos, Point point)
        {
            
            int playerX = pos.X;
            int playerY = pos.Y;

            int specialX = point.pos.X;
            int specialY = point.pos.Y;

            float opp = specialX - playerX;
            float adj = specialY - playerY;

            Dist = opp / adj;

            if (Dist == 0)
            {
                if (playerX != specialX)
                {
                    Dist = playerX - specialX;
                }
                if (playerY != specialY)
                {
                    Dist = playerY - specialY;
                }
            }
            //Console.WriteLine(string.Format("opp: {0}, adj: {1}, Dist: {2}", opp, adj, Dist));

        }
    }
}
