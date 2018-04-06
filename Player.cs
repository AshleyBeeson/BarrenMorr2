using System;
using System.Collections.Generic;

namespace Barrenmoor
{
    public class Player : NPC
    {
        public List<Item> inventory = new List<Item>();
        internal bool hasCrown;

        public Player(string name, Position position) : base(name, position)
        {
            attack = 10;
            defense = 10;
            CalcAttributes();
        }

        public void MovePlayer(string dir)
        {

            

            switch (dir.ToUpper())
            {
                case "MOVE":
                    System.Console.WriteLine("Enter Coords: ");
                    string coords = System.Console.ReadLine();
                    var splitCoords = coords.Split(',');
                    pos.X = int.Parse(splitCoords[0]);
                    pos.Y = int.Parse(splitCoords[1]);
                    break;
                case "N":
                    pos.Y += 1;
                    break;
                case "S":
                    pos.Y -= 1;
                    break;
                case "W":
                    pos.X -= 1;
                    break;
                case "E":
                    pos.X += 1;
                    break;

            }
        }

        internal void Options()
        {
            bool invalid = true;
            while (invalid)
            {
                Console.WriteLine("What would you like to do?\n" +
                "(V)iew Stats\n" +
                "(M)ove");
                string option = Console.ReadLine().ToUpper();

                if (option.Equals("V"))
                {
                    //Allow the player a chance to see their stats
                    displayStats();
                    invalid = false;
                }
                else if (option.Equals("M"))
                {
                    //Get player movement and move them
                    var move = GetMovement();
                    MovePlayer(move);
                    invalid = false;
                }
   
            }
            
        }

        

        private void displayStats()
        {
            Console.WriteLine(string.Format("Name: {0}\n" +
                "Health: {1}\n" +
                "Attack: {2}\n" +
                "Defense: {3}\n", Name,Health,attack,defense));
        }

        private string GetMovement()
        {
            FlavourText.MovementText();
            return Console.ReadLine();
        }

        public void CalcAttributes()
        {
            foreach (var item in inventory)
            {
                if (!item.isUsed)
                {
                    switch (item.type)
                    {
                        case EquipmentType.Offensive:
                            attack += item.ContextVal;
                            break;
                        case EquipmentType.Defensive:
                            defense += item.ContextVal;
                            break;
                        case EquipmentType.Other:
                            attack += item.ContextVal;
                            defense += item.ContextVal;
                            break;
                        default:
                            break;
                    }
                    item.isUsed = true;
                }
            }
        }
    }
}