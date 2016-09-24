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

        public bool hasGameEnded
        {
            get{ return hasGameEnded;}
            set{ hasGameEnded = value;}
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
            hasGameEnded = false;
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
