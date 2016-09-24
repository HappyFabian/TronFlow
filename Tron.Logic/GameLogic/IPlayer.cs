﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tron.Logic.GameLogic
{
    public interface IPlayer
    {
        string playerName { get; set; }
        char playerIcon{ get; set; }
        char playerTrail { get; set; }

        ICoordinate currentCoordinate { get; set; }
        
    }
}
