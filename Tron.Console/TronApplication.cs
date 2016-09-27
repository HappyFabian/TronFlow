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
        private List<IPlayer> _players;

        public TronApplication(IRenderer renderer)
        {
            _renderer = renderer;
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
            int height = Int32.Parse(System.Console.ReadLine());
            System.Console.WriteLine("Enter board height:");
            int width = Int32.Parse(System.Console.ReadLine());
            _renderer.SetBoardSize(width, height);
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
            _players.add(new Player(GetNextCoordinate(), name, t.Color));
        }

        private ICoordinate GetNextCoordinate()
        {
            int x = 0;
            int y = 0;
            if (_players.Count() == 2)
            {

            }
            else if (_players.Count() == 3)
            {

            }
            else if (_players.Count() == 4)
            {

            }
            return new Coordinate(x, y);
        }

        private void GameScreen()
        {
            _renderer.RenderBoard();
        }
    }
}
