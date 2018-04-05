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
            Event eve = null;
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
                      eve = TreasureEventBuilder();
                        break;
                    case EventType.Special:
                        break;
                }
                RunEvent(eve);
            }
            else
            {
                FlavourText.NothingFoundText();
            }
        }

        private void RunEvent(Event e)
        {
            if (e != null)
            {
                Console.WriteLine(e.Desc);

            }
        }

        private Event TreasureEventBuilder()
        {
            Event e = new Event();
            e.Desc = "You found some treasure";
            e.items.Add(itemDataBase.GetItem(0));
            return e;
        }

        private void TrapEventBuilder()
        {
            throw new NotImplementedException();
        }

        private void MonsterEventBuilder()
        {
            throw new NotImplementedException();
        }

    }
}
