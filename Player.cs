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
        }

        public void MovePlayer(string dir)
        {

            CalcAttributes();

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

        private void CalcAttributes()
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