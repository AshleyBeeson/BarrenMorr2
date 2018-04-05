namespace Barrenmoor
{
    public class NPC
    {
        public NPC(string name, Position position)
        {
            Name = name;
            pos = position;
            Health = 100;
        }

        public string Name { get; }
        
        public Position pos { get; set; }

        public int Health { get; set; }
    }
}