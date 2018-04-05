using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barrenmoor
{
    class MonsterDB
    {

        private List<NPC> monsters = new List<NPC>();
        public int size;

        public MonsterDB()
        {
            //Load items from JSON
            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            string path = basePath + "\\..\\..\\monsterdb.json";
            string jsonBody = System.IO.File.ReadAllText(path);
            var json = JObject.Parse(jsonBody);
            var itemlist = json.GetValue("monsters");
            var extractedItems = itemlist.Children();
            foreach (var i in extractedItems)
            {
                
                NPC item = i.ToObject<NPC>();
                monsters.Add(item);
            }

            size = monsters.Count();

        }

        public NPC GetMonsterByIndex(int index)
        {
            return monsters[index];
        }

    }
}
