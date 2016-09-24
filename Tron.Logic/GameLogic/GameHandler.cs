using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tron.Logic.GameLogic
{
    class GameHandler : IGameHandler
    {
        public IGame currentGame
        {
            get { return currentGame; }
            set{ currentGame = value; }
        }

        public void checkLosingConditions(ICoordinate coordinate)
        {
            throw new NotImplementedException();
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

        public void processMagnitude(IMagnitude magnitude)
        {
           
           var newCoordinates = currentGame.currentPlayer.currentCoordinate;
           var magnitudeCoordinates = magnitude.returnValues();
         
           newCoordinates.coordinateX += magnitudeCoordinates.coordinateX;
           newCoordinates.coordinateY += magnitudeCoordinates.coordinateY;

            if(newCoordinates.coordinateX > currentGame.map.mapArray.GetUpperBound(0))
            {
                newCoordinates.coordinateX = newCoordinates.coordinateX - currentGame.map.mapArray.GetUpperBound(0);
            }
            if (newCoordinates.coordinateX < currentGame.map.mapArray.GetLowerBound(0))
            {
                newCoordinates.coordinateX =  currentGame.map.mapArray.GetUpperBound(0) - newCoordinates.coordinateX;
            }

            if (newCoordinates.coordinateY > currentGame.map.mapArray.GetUpperBound(1))
            {
                newCoordinates.coordinateY = newCoordinates.coordinateY - currentGame.map.mapArray.GetUpperBound(1);
            }
            if (newCoordinates.coordinateY < currentGame.map.mapArray.GetLowerBound(1))
            {
                newCoordinates.coordinateY = currentGame.map.mapArray.GetUpperBound(1) - newCoordinates.coordinateY;
            }



            //To Implement checkLosingConditions here
            currentGame.currentPlayer.updateCoordinate(newCoordinates);
        }

        public void processMove(IMovement move)
        {

            var currentPlayer = currentGame.currentPlayer;
            foreach(var mag in move.movementMagnitudes.magnitudes)
            {
                currentGame.map.markTile(currentPlayer.currentCoordinate, currentPlayer.playerTrail);
                processMagnitude(mag);
                currentGame.map.markTile(currentGame.currentPlayer.currentCoordinate, currentGame.currentPlayer.playerIcon);
            }
        }
    }
}
