using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tron.Logic.GameLogic;

namespace Tron.Console
{
    public interface IRenderer
    {
        void SetBoardSize(int width, int height);
        void RenderBoard();
        void AddPlayers();
        void Menu();
        void ListPlayers(List<IPlayer> players);
    }
}
