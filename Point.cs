namespace Barrenmoor
{
    public class Point
    {
        public Position pos { get; }
        
        public EventType type { get; }

        public Point(Position pos, EventType type)
        {
            this.pos = pos;
            this.type = type;
        }
        
    }
}