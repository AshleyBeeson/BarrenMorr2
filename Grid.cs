using System.Collections.Generic;
using System;

namespace Barrenmoor
{
    public class Grid
    {
        
        private List<Point> EventPoints = new List<Point>();
        private int maxSize;
        private static readonly Random rand = new Random();

        public Grid(int maxSizeOfGrid, int maxAmtOfEvents)
        {
            this.maxSize = maxSizeOfGrid;
            for (int i = 0; i < maxAmtOfEvents; i++)
            {
                EventPoints.Add(GenerateEvent());    
            }
            EventPoints.Add(new Point(new Position(rand.Next(maxSizeOfGrid), rand.Next(maxSizeOfGrid)), EventType.Special));


            List<string> events = new List<string>();
            foreach (var item in EventPoints)
            {
                events.Add(item.ToString());
            }
            string basePath = AppDomain.CurrentDomain.BaseDirectory;
            string path = basePath + "\\..\\..\\eventList.txt";
            System.IO.File.WriteAllLines(path, events);
        }

        private Point GenerateEvent()
        {
            int x = rand.Next(-maxSize,maxSize);
            int y = rand.Next(-maxSize, maxSize);
            Position pos = new Position(x,y);
            EventType e;
        
            switch (rand.Next(4))
            {
                default:
                    e = EventType.Monster;
                    break;
                case 0:
                    e = EventType.Monster;
                    break;
                case 1:
                    e = EventType.Treasure;
                    break;
                case 2:
                    e = EventType.Trap;
                    break;
            }

            return new Point(pos, e);
        }

        public Point CheckPlayerPos(Position pos)
        {

            Compass.GetDistance(pos, EventPoints[EventPoints.Count-1]);
            Compass.FindNearestEvent(pos,EventPoints);
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