using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tron.Logic.GameLogic
{
    public interface IGame
    {
       bool hasGameEnded { get; set; }
        IPlayer currentPlayer { get; set; }
        List<IPlayer> players { get; set; }
        IMap map { get; set; }
        void Prepare(ICoordinate size, List<IPlayer> players);
        void updateCurrentPlayer(IPlayer currentPlayer);
    }
}
