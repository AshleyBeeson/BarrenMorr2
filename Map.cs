using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Map1
{
    class Program
    {
        static void Main(string[] args)
        {
            MapClass test = new MapClass();
            Console.WriteLine(test.TreasureDist(1, 1, 0, 0));
        }
    }
}
