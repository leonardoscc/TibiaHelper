﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TibiaHeleper.MemoryOperations
{
    public static class Constants
    {

        public static int GameWindowWidthSquares { get; set; }
        public static int GameWindowHeightSquares { get; set; }
        public static int ShieldYOffset { get; }
        public static int ShieldXOffset { get;}
        public static int MaximizeEQButtonXOffset { get; }
        public static int MaximizeEQButtonYOffset { get; }

        static Constants()
        {
            GameWindowHeightSquares = 11;
            GameWindowWidthSquares = 15;
            ShieldYOffset = 75;
            ShieldXOffset = -73;
            MaximizeEQButtonXOffset = -160;
            MaximizeEQButtonYOffset = 10;
        }


    }
}
