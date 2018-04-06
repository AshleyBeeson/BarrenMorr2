using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Barrenmoor
{
    class MapClass
    {
        //COORDINATES OF PLAYER AND TREASURE
        int PlayerX, PlayerY, TreasureX, TreasureY;

        //RETURNS THE DISTANCE BETWEEN THE PLAYER AND THE TREASURE
        public double TreasureDist(int PlayerParamX, int PlayerParamY, int TreasureParamX, int TreasureParamY)
        {
            return Math.Round(Math.Sqrt((PlayerParamX - TreasureParamX) * (PlayerParamX - TreasureParamX) + (PlayerParamY - TreasureParamY) * (PlayerParamY - TreasureParamY)),2);
        }
    }
}
