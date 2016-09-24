using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tron.Logic.GameLogic
{
    public class Game : IGame
    {
        public IPlayer currentPlayer
        {
            get{return currentPlayer;}
            set { currentPlayer = value; }
        }

        public IMap map
        {
            get{ return map; }
            set{ map = value;}
        }

        public List<IPlayer> players
        {
            get{ return players;}
            set{ players = value; }
        }

        public void Prepare(ICoordinate size, List<IPlayer> players)
        {
            map.Prepare(size);
            this.players = players;
        }

        public void updateCurrentPlayer(IPlayer currentPlayer)
        {
           this.currentPlayer = currentPlayer;
        }
    }
}
