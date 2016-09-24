using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tron.Logic.GameLogic
{
    public class Player : IPlayer
    {
        public Player(ICoordinate startingCoordinate, string playerName, string color)
        {
            this.currentCoordinate = startingCoordinate;
            this.playerName = playerName;
            this.playerIcon = playerIcon;
            this.playerTrail = playerTrail;
        }

        public ICoordinate currentCoordinate
        {
            get {return currentCoordinate;}
            set {currentCoordinate = value;}
        }

        public ITile playerIcon
        {
            get { return playerIcon; }
            set { playerIcon = value; }
        }

        public string playerName
        {
            get { return playerName;}
            set {playerName = value;}
        }

        public ITile playerTrail
        {
            get { return playerTrail; }
            set{ playerTrail = value;}
        }

        public void updateCoordinate(ICoordinate newCoordinate)
        {
            currentCoordinate = newCoordinate;
        }
    }
}
