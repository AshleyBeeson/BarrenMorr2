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
            playerX   = 0;
            playerY   = 0;
            playerHP  = 20;
            playerAtk = 10;
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

        public void MovePosition(string movement)
        {
            movement = movement.ToLower();

            if (movement.Equals("north") || movement.Equals("n"))
            {
                playerY++;
            }
            else if (movement.Equals("south") || movement.Equals("s"))
            {
                playerY--;
            }
            else if (movement.Equals("east") || movement.Equals("e"))
            {
                playerX++;
            }
            else if (movement.Equals("west") || movement.Equals("w"))
            {
                playerX--;
            }
            else Console.WriteLine("Invalid input, please input a valid input");
        }

        public void DisplayEncounterStory()
        {
            Random rnd = new Random();
            int random = rnd.Next(1, 11);
            switch (random)
            {
                case 1:
                    Console.WriteLine("The mighty goblin has appeared. He the king of Zordon and is unhappy with your presence. The battle begins…");
                    break;
                case 2:
                    Console.WriteLine("A group of trolls have combined into one robo - troll.It is time to prove your strength and defeat these pesky beasts.");
                    break;
                case 3:
                    Console.WriteLine("The mighty Grogo just ambushed you, he used his big foot to stomp and barely missed you. It’s now your chance to show him who’s the real boss.");
                    break;
                case 4:
                    Console.WriteLine("The elves are unhappy with your presence and demand a fight to the death. Earn their respect and defeat one elf foe.");
                    break;
                case 5:
                    Console.WriteLine("Many generations ago, you angered the sandwich lady and did not give her a payment. You have finally crossed paths and she is now fed up and wants you dead. Defeat her to move forward.");
                    break;
                case 6:
                    Console.WriteLine("The 7th leader of Azeroth, conqueror of the owl under the moon has sent his band of goons to infiltrate your treasure hunt. Eliminate the pests.");
                    break;
                case 7:
                    Console.WriteLine("The princess of Adlez’s body guards are threatened by your presence. The princess has escaped but the body guards have challenged you and will not allow you to continue your journey.");
                    break;
                case 8:
                    Console.WriteLine("Leeroy Jenkins has charged you down. You are compelled by his roar and cannot carry on with your journey until he is down.");
                    break;
                case 9:
                    Console.WriteLine("Bash Candicoot crawls from under a log and attempts to scratch you. You successfully fend of his attack. It’s time to show this monster who is boss.");
                    break;
                case 10:
                    Console.WriteLine("A swarm of insects has formed into an insect man. The insect man wants nothing but trouble and is not going to leave you alone until he is taken down.");
                    break;
            }
        }

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
