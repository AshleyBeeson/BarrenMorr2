using Newtonsoft.Json;

namespace Barrenmoor
{
    public class NPC
    {
        internal int defense;
        internal int attack;

        public NPC(string name, Position position)
        {
            Name = name;
            pos = position;
            Health = 100;
        }

        [JsonConstructor]
        public NPC(string name, int health, int attack, int defense)
        {
            Name = name;
            Health = health;
            this.attack = attack;
            this.defense = defense;
        }

        public string Name { get; }
        
        public Position pos { get; set; }

        public int Health { get; set; }
    }
}