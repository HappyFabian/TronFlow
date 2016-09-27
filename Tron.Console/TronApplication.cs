using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tron.Logic.GameLogic;

namespace Tron.Console
{
    public class TronApplication : IApplication
    {
        private IRenderer _renderer;
        private IGameHandler _game;
        private List<IPlayer> _players;
        private int _height;
        private int _width;

        public TronApplication(IRenderer renderer, IGameHandler game)
        {
            _renderer = renderer;
            _game = game;
        }

        public void Run()
        {
            MenuScreen();
        }

        private void MenuScreen()
        {
            _renderer.Menu();
            int input = Int32.Parse(System.Console.ReadLine());
            if (input == 1)
            {
                BoardSizeSelectionScreen();
            }
            else
            {
                Environment.Exit(0);
            }
        }

        private void BoardSizeSelectionScreen()
        {
            System.Console.WriteLine("Enter board width:");
            _height = Int32.Parse(System.Console.ReadLine());
            System.Console.WriteLine("Enter board height:");
            _width = Int32.Parse(System.Console.ReadLine());
            _renderer.SetBoardSize(_width, _height);
            AddPlayersScreen();
        }

        private void AddPlayersScreen()
        {
            _players = new List<IPlayer>();
            int input = 0;
            while(input != 2){
                _renderer.AddPlayers();
                input = Int32.Parse(System.Console.ReadLine());
                if (input == 1)
                    NewPlayerScreen();
            }
            _game.newGame(_players, new Coordinate(_width, _height));
            GameScreen();
        }

        private void NewPlayerScreen()
        {
            if (_players.Count() == 4)
            {
                System.Console.WriteLine("4 Players max");
                return;
            }
            System.Console.WriteLine("Enter Player Name:");
            string name = System.Console.ReadLine();
            _players.Add(new Player(GetNextCoordinate(), name, GetNextColor()));
        }

        private ICoordinate GetNextCoordinate()
        {
            int x = 0;
            int y = 0;
            if (_players.Count() == 2)
            {
                x = _width - 1;
            }
            else if (_players.Count() == 3)
            {
                y = _height - 1;
            }
            else if (_players.Count() == 4)
            {
                x = _width - 1;
                y = _height - 1;
            }
            return new Coordinate(x, y);
        }

        private string GetNextColor()
        {
            if (_players.Count() == 2)
            {
                return "Blue";
            }
            else if (_players.Count() == 3)
            {
                return "Green";
            }
            else if (_players.Count() == 4)
            {
                return "Yellow";
            }
            return "Red";
        }

        private void GameScreen()
        {
            bool hasGameEnded = false;
            while (hasGameEnded)
            {
                _renderer.RenderBoard(_game.ReturnPlayers());
                _game.processMove();
                _game.endTurn();
                hasGameEnded = _game.hasGameEnded();
            }
        }
    }
}
