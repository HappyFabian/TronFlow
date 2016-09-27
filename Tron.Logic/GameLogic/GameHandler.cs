using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tron.Logic.ParserService;

namespace Tron.Logic.GameLogic
{
    public class GameHandler : IGameHandler
    {
        private IParser _parser;
        private IGame _currentGame;

        public GameHandler(IParser parser)
        {
            _parser = parser;
        }
        public IGame currentGame
        {
            get { return _currentGame; }
            set{ _currentGame = value; }
        }

        public List<IPlayer> ReturnPlayers()
        {
            return currentGame.players;
        }

        public bool checkLosingConditions(ICoordinate coordinate)
        {
            if(currentGame.map.returnTile(coordinate) != currentGame.map.defaultTile)
            {
                return true;
            }
            return false;
        }

        public bool checkWinningConditions()
        {
            if(currentGame.players.Count == 1)
            {
                return true;
            }
            return false;
        }

        public void endGame()
        {
            currentGame = null;
        }

        public IMagnitude getMagnitudesFromMove(IMovement move)
        {
            return move.ReturnMagnitudes();
        }

        public void newGame(List<IPlayer> players, ICoordinate mapSize)
        {
            currentGame = new Game();
            currentGame.Prepare(mapSize,players);
        }

        public void removeLosingPlayer()
        {
            var nextPlayerIndex = currentGame.players.IndexOf(currentGame.currentPlayer);
            currentGame.players.Remove(currentGame.currentPlayer);

            if (nextPlayerIndex > currentGame.players.Count() - 1)
            {
                nextPlayerIndex = 0;
            }
            currentGame.updateCurrentPlayer(currentGame.players.ElementAt(nextPlayerIndex));

        }

        public void processMagnitude(IMagnitude magnitude)
        {
           var newCoordinates = currentGame.currentPlayer.currentCoordinate;
           var magnitudeCoordinates = magnitude.returnValues();           
           newCoordinates.coordinateX += magnitudeCoordinates.coordinateX;
           newCoordinates.coordinateY += magnitudeCoordinates.coordinateY;
            if(newCoordinates.coordinateX > currentGame.map.mapArray.GetUpperBound(0))
            {newCoordinates.coordinateX = newCoordinates.coordinateX - currentGame.map.mapArray.GetUpperBound(0);}

            if (newCoordinates.coordinateX < currentGame.map.mapArray.GetLowerBound(0))
            {newCoordinates.coordinateX =  currentGame.map.mapArray.GetUpperBound(0) - newCoordinates.coordinateX;}

            if (newCoordinates.coordinateY > currentGame.map.mapArray.GetUpperBound(1))
            {newCoordinates.coordinateY = newCoordinates.coordinateY - currentGame.map.mapArray.GetUpperBound(1);}
            if (newCoordinates.coordinateY < currentGame.map.mapArray.GetLowerBound(1))
            {newCoordinates.coordinateY = currentGame.map.mapArray.GetUpperBound(1) - newCoordinates.coordinateY;}



            if(!checkLosingConditions(newCoordinates))
            {currentGame.currentPlayer.updateCoordinate(newCoordinates);}
            else
            {
                removeLosingPlayer();
                if(checkWinningConditions())
                {
                    currentGame.hasGameEnded = true;
                }
                
            }
        }
        public void endTurn()
        {
            var nextPlayerIndex = currentGame.players.IndexOf(currentGame.currentPlayer) + 1;
            if (nextPlayerIndex > currentGame.players.Count() - 1)
            {
                nextPlayerIndex = 0;
            }
            currentGame.updateCurrentPlayer(currentGame.players.ElementAt(nextPlayerIndex));

        }

        public bool hasGameEnded()
        {
            return currentGame.hasGameEnded;
        }

        public void processMove()
        {
            var move = _parser.GetNextMovement();
            if (!currentGame.hasGameEnded)
            {
                var currentPlayer = currentGame.currentPlayer;
                foreach (var mag in move.movementMagnitudes.magnitudes)
                {
                    currentGame.map.markTile(currentPlayer.currentCoordinate, currentPlayer.playerTrail);
                    processMagnitude(mag);
                    currentGame.map.markTile(currentGame.currentPlayer.currentCoordinate, currentGame.currentPlayer.playerIcon);
                }
            }
            
        }
    }
}
