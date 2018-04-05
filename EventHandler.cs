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
        private static readonly Random rand = new Random();
        

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
                        MonsterEventBuilder(player);
                        break;
                    case EventType.Trap:
                        TrapEventBuilder(player);
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

            //Create big bad
            NPC BigBad = new NPC("Big Bad", 500, 30, 15);

            //Fight Boss
            CombatLoop.Fight(BigBad, player);
            //Console.WriteLine("You should fight the big bad here but I've not built it yet so....");

            //Success
            player.hasCrown = true;
        }

        private void TreasureEventBuilder(Player player)
        {
            //Get Item from DB
            Item item = null;
            while (item == null) {
                item = itemDataBase.GetItemByIndex(rand.Next(itemDataBase.size));
                if (item.Name.Equals("Crown"))
                {
                    item = null;
                }
            }
            //Tell the player what they got
            Console.WriteLine(string.Format("You found {0}" , item.Name));
            //Add item to players inventory
            player.inventory.Add(item);
        }

        private void TrapEventBuilder(Player player)
        {
            Console.WriteLine("Ah you fell into a trap");
            player.Health -= 10;
        }

        private void MonsterEventBuilder(Player player)
        {
            //TODO: Buld Monster DB
            //Get Monster from DB
            var m = new NPC("Troll", 100, 5, 3);
            //Tell player what they are fighting 
            Console.WriteLine(string.Format("Ahh it's a {0}", m.Name));
            //Fight Loop
            CombatLoop.Fight(m, player);
            //Win Loot
            TreasureEventBuilder(player);
        }

    }
}
