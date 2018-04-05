using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barrenmoor
{
    class Event
    {

        public string Desc { get; set; }
        public List<Item> items = new List<Item>();
        public NPC monster { get; set; }

    }
}
