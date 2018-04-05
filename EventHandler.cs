using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barrenmoor
{
    class EventHandler
    {
        private ItemDataBase itemDataBase;


        public EventHandler()
        {
            itemDataBase = new ItemDataBase();
        }

        public void Handle(Point point, Player player)
        {
            
            if (point != null)
            {
                Console.WriteLine(string.Format("EVENT TYPE: {0}", point.type));
                switch (point.type)
                {
                    case EventType.Monster:
                        break;
                    case EventType.Trap:
                        break;
                    case EventType.Treasure:
                      TreasureEventBuilder(player);
                        break;
                    case EventType.Special:
                        SpecialEventBuilder(player);
                        break;
                }
                
            }
            else
            {
                FlavourText.NothingFoundText();
            }
        }

        private void SpecialEventBuilder(Player player)
        {
            //Get crown
            Item item = itemDataBase.GetItemByName("Crown");
            if (item == null)
            {
                Console.WriteLine("Error couldn't find the crown in DB");
                Console.ReadLine();
                Environment.Exit(0);
            }
            player.inventory.Add(item);
            
            //Fight Boss


            //Success
            player.hasCrown = true;
        }

        private void TreasureEventBuilder(Player player)
        {
            //Get Item from DB
            Item item = itemDataBase.GetItemByIndex(0);
            //Tell the player what they got
            Console.WriteLine(string.Format("You found {0}" , item.Name));
            //Add item to players inventory
            player.inventory.Add(item);
        }

        private void TrapEventBuilder()
        {
            throw new NotImplementedException();
        }

        private void MonsterEventBuilder(Player player)
        {
            //Get Monster from DB
            var m = new NPC("Troll", 100);
            //Tell player what they are fighting 
            Console.WriteLine(string.Format("Ahh it's a {0}", m.Name));
            //Fight Loop
            CombatLoop.Fight(m, player);
        }

    }
}
