using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tron.Logic.GameLogic
{
    class Player : IPlayer
    {
        public Player(ICoordinate startingCoordinate, string playerName,char playerIcon, char playerTrail)
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

        public char playerIcon
        {
            get { return playerIcon; }
            set { playerIcon = value; }
        }

        public string playerName
        {
            get { return playerName;}
            set {playerName = value;}
        }

        public char playerTrail
        {
            get { return playerTrail; }
            set{ playerTrail = value;}
        }
    }
}
