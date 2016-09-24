using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tron.Logic.GameLogic;

namespace Tron.Logic.Decorator
{
    public abstract class PlayerDecorator : IPlayer
    {
        private IPlayer _player;

        public PlayerDecorator(IPlayer player)
        {
            _player = player;
        }
        public string playerName
        {
            get { return _player.playerName; }
            set { _player.playerName = value; }
        }

        public char playerIcon
        {
            get { return _player.playerIcon; }
            set { _player.playerIcon = value; }
        }

        public char playerTrail
        {
            get { return _player.playerTrail; }
            set { _player.playerTrail = value; }
        }

        public ICoordinate currentCoordinate
        {
            get { return _player.currentCoordinate; }
            set { _player.currentCoordinate = value; }
        }
    }
}
