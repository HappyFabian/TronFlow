using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tron.Console
{
    public class Game : IGame
    {
        private IRenderer _renderer;

        public Game(IRenderer renderer)
        {
            _renderer = renderer;
        }

        public void Run()
        {
            _renderer.SetBoardSize(5,5);
            _renderer.RenderBoard();
        }
    }
}
