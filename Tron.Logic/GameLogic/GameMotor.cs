using System;
using System.Collections.Generic;
using Tron.Logic.Movements;

namespace Tron.Logic.GameLogic
{
    public class GameMotor:IGameMotor
    {
        private Board gameBoard;
        public List<Player> gamePlayers;
        public bool GameOn { get; set; }

        public GameMotor(Board board, List<Player> players)
        {
            gameBoard = board;
            gamePlayers = players;
            GameOn = true;
        }

        public void ExecuteMove(IMovement movement)
        {
            var playerToMove = gamePlayers.Find(delegate (Player player) { return player.Name == movement.PlayerName; });
            var magnitudes = movement.ReturnMagnitudes();

            while(magnitudes.Count > 0)
            {
                var direction = magnitudes[0].returnValues();
                var actualLocation = new Tuple<int, int>(playerToMove.XCoordinate, playerToMove.YCoordinate);
                var currentMagnitude = new Tuple<int,int>(actualLocation.Item1 + direction.Item1, actualLocation.Item2 + direction.Item2) ;

                var RebasedMovement = calculateMove((Board)gameBoard,currentMagnitude);

                bool IsMoveValid = checkValidMove(RebasedMovement.Item1, RebasedMovement.Item2, gameBoard.defaultObject);

                if (IsMoveValid)
                {
                    gameBoard.MarkSpot(RebasedMovement.Item1, RebasedMovement.Item2, playerToMove.Mark);
                    magnitudes.RemoveAt(0);
                }
                GameOn = false;
                
            }
        }

        private bool checkValidMove(int xCoordinate, int yCoordinate, object defaultObject)
        {
            if (gameBoard.Map[xCoordinate, yCoordinate].Equals(defaultObject))
            {
                return false;
            }
            return true;
        }

        private Tuple<int,int> calculateMove(Board board, Tuple<int,int> currentMagnitude)
        {
            Tuple<int, int> rebasedMagninuted = currentMagnitude;
           
            if(currentMagnitude.Item1 < 0)
            {
                rebasedMagninuted = new Tuple<int,int>(board.Map.GetLength(0)-1,rebasedMagninuted.Item2);
            }
            if (currentMagnitude.Item1 > board.Map.GetLength(0))
            {
                rebasedMagninuted = new Tuple<int, int>(0, rebasedMagninuted.Item2);
            }

            if (currentMagnitude.Item2 < 0)
            {
                rebasedMagninuted = new Tuple<int, int>(rebasedMagninuted.Item2,board.Map.GetLength(1) - 1);
            }
            if (currentMagnitude.Item2 > board.Map.GetLength(0))
            {
                rebasedMagninuted = new Tuple<int, int>(rebasedMagninuted.Item2, 0);
            }


            return rebasedMagninuted;
        }
    }
}
