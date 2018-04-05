using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barrenmoor
{
    class ItemDataBase
    {

        private List<Item> items = new List<Item>();
        public int size;

        public ItemDataBase()
        {
            //Load items from JSON
            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            string path = basePath +  "\\..\\..\\itemdb.json";
            string jsonBody = System.IO.File.ReadAllText(path);
            var json = JObject.Parse(jsonBody);
            var itemlist = json.GetValue("items");
            var extractedItems = itemlist.Children();
            foreach (var i in extractedItems)
            {
                Item item = i.ToObject<Item>();
                items.Add(item);
            }

            size = items.Count();

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
