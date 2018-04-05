using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barrenmoor
{
    class ItemDataBase
    {

        private List<Item> items = new List<Item>();

        public ItemDataBase()
        {
            //Load items from JSON
            items.Add(new Item("Rusty sword", 1));
        }


        public Item GetItemByIndex(int index)
        {
            return items[index];
        }

        internal Item GetItemByName(string itemName)
        {
            foreach (var item in items)
            {
                if (item.Name == itemName)
                {
                    return item;
                }
            }
            return null;
        }
    }
}
