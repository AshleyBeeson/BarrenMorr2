using System.Collections.Generic;
using System;

namespace Barrenmoor
{
    public class Grid
    {
        
        private List<Point> EventPoints = new List<Point>();
        private int maxSize;

        public Grid(int maxSizeOfGrid, int maxAmtOfEvents)
        {
            this.maxSize = maxSizeOfGrid;
            for (int i = 0; i < maxAmtOfEvents; i++)
            {
                EventPoints.Add(new Point(new Position(0, 0), EventType.Treasure));
                EventPoints.Add(GenerateEvent());    
            }
            
        }

        private Point GenerateEvent()
        {

            Random rand = new Random();
            int x = rand.Next(maxSize);
            int y = rand.Next(maxSize);
            Position pos = new Position(x,y);
            EventType e;
        
            switch (rand.Next(3))
            {
                default:
                    e = EventType.Monster;
                    break;
                case 1:
                    e = EventType.Monster;
                    break;
                case 2:
                    e = EventType.Treasure;
                    break;
                case 3:
                    e = EventType.Trap;
                    break;
            }

            return new Point(pos, e);
        }


        public Point CheckPlayerPos(Position pos)
        {
            foreach (var Point in EventPoints)
            {
                var PointPos = Point.pos;
                if (PointPos.X == pos.X)
                {
                    if (PointPos.Y == pos.Y)
                    {
                        return Point;
                    }
                }
            }
            return null;
        }
        
    }
}