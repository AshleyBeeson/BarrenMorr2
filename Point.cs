namespace Barrenmoor
{
    public class Point
    {
        public Position pos { get; }
        
        public EventType type { get; }

        public bool isUsed { get; set; }

        public Point(Position pos, EventType type)
        {
            this.pos = pos;
            this.type = type;
        }
        

        override
        public string ToString()
        {
            return string.Format("Event type: {0}, Event Position: {1},{2}", type, pos.X,pos.Y);
        }

    }
}