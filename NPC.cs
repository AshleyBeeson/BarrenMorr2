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

        public NPC(string name, int health, int att, int def)
        {
            Name = name;
            Health = health;
            attack = att;
            defense = def;
        }

        public string Name { get; }
        
        public Position pos { get; set; }

        public int Health { get; set; }
    }
}