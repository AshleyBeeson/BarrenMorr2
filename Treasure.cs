using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barrenmoor
{
    class Treasure
    {
        private int treasureX, treasureY;
        private int treasureCount;
        private int treasureLevel;
        private int points;

        public Treasure()
        {

        }

        public int DetermineTreasureLevel()
        {
            Random rnd = new Random();
            treasureLevel = treasureX = rnd.Next(1, 3);

            if (treasureLevel == 1)
            {
                points = 5;
                
            }
            else if ( treasureLevel == 2)
            {
                points = 10;
            }
            else if ( treasureLevel == 3)
            {
                points = 15;
            }
            return points;
        }

        public int GetTreasurePoints()
        {
            return points;
        }

        public int GetX()
        {
            return treasureX;
        }

        public int GetY()
        {
            return treasureY;
        }

        public void SetX(int x)
        {
            treasureX = x;
        }

        public void SetY(int y)
        {
            treasureY = y;
        }

        public void RandomTreasurePosition()
        {
            Random rnd = new Random();
            treasureX = rnd.Next(-5, 5);
            treasureY = rnd.Next(-5, 5);
        }
    
    }
}
