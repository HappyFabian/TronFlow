using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tron.Logic.GameLogic
{
    public class Game : IGame
    {
        private IPlayer _currentPlayer;
        private bool _hasGameEnded;
        private IMap _map;
        private List<IPlayer> _players;

        public IPlayer currentPlayer
        {
            get{return _currentPlayer;}
            set { _currentPlayer = value; }
        }

        public bool hasGameEnded
        {
            get{ return _hasGameEnded;}
            set{ _hasGameEnded = value;}
        }

        public IMap map
        {
            get{ return _map; }
            set{ _map = value;}
        }

        public List<IPlayer> players
        {
            get{ return _players;}
            set{ _players = value; }
        }

        public void Prepare(ICoordinate size, List<IPlayer> players)
        {
            hasGameEnded = false;
            var tile = new Tile();
            tile.value = '_';
            map.defaultTile = tile;
            map.Prepare(size);
            this.players = players;
            updateCurrentPlayer(players.ElementAt(0));
        }

        public void updateCurrentPlayer(IPlayer currentPlayer)
        {
           this.currentPlayer = currentPlayer;
        }
    }
}
