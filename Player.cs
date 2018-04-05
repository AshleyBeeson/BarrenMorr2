using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barrenmoor
{
    class Player
    {
        private int playerX, playerY;

        public int GetX()
        {
            return playerX;

        }

        public int GetY()
        {
            return playerY;
        }

        public void SetX(int x)
        {
            playerX = x;
        }

        public void SetY(int y)
        {
            playerY = y;
        }

        public void MovePosition (string movement)
        {
            if (movement.Equals("North") || movement.Equals("N"))
            {
                playerY++;
            }
            if (movement.Equals("South") || movement.Equals("S"))
            {
                playerY--;
            }
            if (movement.Equals("East") || movement.Equals("E"))
            {
                playerX++;
            }
            if (movement.Equals("West") || movement.Equals("W"))
            {
                playerY--;
            }
            else Console.WriteLine("Invalid input, please input a valid input");




        }
    }

}
