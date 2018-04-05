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


        public Item GetItem(int index)
        {
            throw new NotImplementedException();
        }

    }
}
