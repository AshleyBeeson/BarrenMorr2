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
        private int gold;

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
