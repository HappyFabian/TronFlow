using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tron.Logic.GameLogic
{
    public interface IGameHandler
    {
        IGame currentGame { get; set; }
        void newGame(List<IPlayer> players, ICoordinate mapSize);
        IMagnitude getMagnitudesFromMove(IMovement move);
        void processMagnitude(IMagnitude magnitude);
        void processMove();
        bool checkLosingConditions(ICoordinate coordinates);
        void removeLosingPlayer();
        bool checkWinningConditions();
        List<IPlayer> ReturnPlayers();

        void endTurn();
        bool hasGameEnded();
        void endGame();
        
        
        
    }
}
