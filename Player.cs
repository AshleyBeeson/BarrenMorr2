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
        private int points;
        private int playerHP, playerAtk;

        public Player()
        {
            playerX = 0;
            playerY = 0;
        }


        public void SetPoints(int addPoints)
        {
            points = addPoints;
        }

        public int GetHP()
        {
            return playerHP;
        }

        public void SetHP(int hp)
        {
            playerHP = hp;
        }

        public int GetAtk()
        {
            return playerAtk;
        }

        public void SetAtk(int atk)
        {
            playerAtk = atk;
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

            public void IntroTxt()
        {
            Console.WriteLine("You wake up. On a desolate barren Moor. You're breathless you don't");
            Console.WriteLine("remember who you are. All you remember is that you're a SandyMan.");
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine("You look in your pockets and feel something hard. lel.");
            Console.WriteLine("You realise it's not a compass but it seems to be showing you the distance to something.");
            Console.WriteLine("-------------------------------------------------------------------------------------------");
        }



        }
    }

}
