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

        public Player()
        {
            playerX = 0;
            playerY = 0;
        }

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
            movement = movement.ToLower();

            if (movement.Equals("north") || movement.Equals("n"))
            {
                playerY++;
            }
            else if(movement.Equals("south") || movement.Equals("s"))
            {
                playerY--;
            }
            else if(movement.Equals("east") || movement.Equals("e"))
            {
                playerX++;
            }
            else if(movement.Equals("west") || movement.Equals("w"))
            {
                playerX--;
            }
            else Console.WriteLine("Invalid input, please input a valid input");




        }
    }

}
