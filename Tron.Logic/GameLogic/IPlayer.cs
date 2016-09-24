using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tron.Logic.GameLogic
{
    public interface IPlayer
    {
        string playerName { get; set; }
        ITile playerIcon{ get; set; }
        ITile playerTrail { get; set; }

        ICoordinate currentCoordinate { get; set; }
        
    }
}
