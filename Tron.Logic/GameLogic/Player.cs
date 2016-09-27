using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tron.Logic.GameLogic
{
    public class Player : IPlayer
    {

        private ICoordinate _currentCoordinate;
        private ITile _playerIcon;
        private string _playerName;
        private ITile _playerTrail;

        public Player(ICoordinate startingCoordinate, string playerName, string color)
        {
            this.currentCoordinate = startingCoordinate;
            this.playerName = playerName;
            this.playerIcon = playerIcon;
            this.playerTrail = playerTrail;
        }

        public ICoordinate currentCoordinate
        {
            get {return _currentCoordinate;}
            set {_currentCoordinate = value;}
        }

        public ITile playerIcon
        {
            get { return _playerIcon; }
            set { _playerIcon = value; }
        }

        public string playerName
        {
            get { return _playerName;}
            set {_playerName = value;}
        }

        public ITile playerTrail
        {
            get { return _playerTrail; }
            set{ _playerTrail = value;}
        }

        public void updateCoordinate(ICoordinate newCoordinate)
        {
            currentCoordinate = newCoordinate;
        }
    }
}
