using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tron.Logic.GameLogic;

namespace Tron.Logic.Player
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
            get { _player.playerName }
            set { _player.playerName = value; }
        }

        public char playerIcon
        {
            get { _player.playerIcon }
            set { _player.playerIcon = value; }
        }

        public char playerTrail
        {
            get { _player.playerTrail }
            set { _player.playerTrail = value; }
        }

        public ICoordinate currentCoordinate
        {
            get { _player.currentCoordinate }
            set { _player.currentCoordinate = value; }
        }
    }
}
