using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monster
{
    class level
    {
        // read in points, determine level from points. 
        int Points;
        int Level;

        public level()
        {
            Points = 0;
            Level = 0;
        }

        public void SetLevel(int level)
        {
            Level = level;
        }

        public void SetPoints(int points)
        {
            Points = points;
        }


        //read in level, and then determines the points based on level provided.
        public int levels(int Level) {

            switch (Level)
            {
                case (0):
                    Points += 2;
                    break;

                case (1):
                    Points += 4;
                    break;

                case (2):
                    Points += 6;
                    break;

                case (3):
                    Points += 8;
                    break;

                case (4):
                    Points += 10;
                    break;

                case (5):
                    Points += 15;
                    break;

                case (6):
                    Points += 20;
                    break;

                case (7):
                    Points += 40;
                    break;

                case (8):
                    Points += 50;
                    break;

                case (9):
                    Points += 90;
                    break;

                case (10):
                    Points += 100;
                    break;

                default:
                    Points += 0;
                    break;
            }

            return Points;


        }

    }
}
