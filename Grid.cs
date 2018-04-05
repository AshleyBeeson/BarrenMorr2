using System.Collections.Generic;

namespace Barrenmoor
{
    public class Grid
    {
        
        private List<Point> EventPoints = new List<Point>();

        public Grid()
        {
            for (int i = 0; i < 10; i++)
            {
                EventPoints.Add(new Point(new Position(0,0), EventType.Treasure));    
            }
            
        }

        public Point CheckPlayerPos(Position pos)
        {
            foreach (var point in EventPoints)
            {
                var PointPos = point.pos;
                if (PointPos.X != pos.X)
                {
                    return null;
                }
            }
            
        }
        
    }
}