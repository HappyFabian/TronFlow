using System.Collections.Generic;
using Tron.Logic.Movements;

namespace Tron.Logic.GameLogic
{
    public class GameMotor:IGameMotor
    {
        private IBoard gameBoard;
        public List<IPlayer> gamePlayers;

        public GameMotor(GameBoard board, List<IPlayer> players)
        {
            gameBoard = board;
            gamePlayers = players;
        }

        public void ExecuteMove(IMovement move)
        {
            
        }
    }
}
