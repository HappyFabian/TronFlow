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

        public TronApplication(IRenderer renderer)
        {
            _renderer = renderer;
        }

        public void Run()
        {
            MenuScreen();
            _renderer.SetBoardSize(5,5);
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
            List<IPlayer> players = new List<IPlayer>();
            string input = "";
            do{
                _renderer.AddPlayers();
                input = System.Console.ReadLine();
            }while(!input.Equals("done"));
            GameScreen(players);
        }

        private void GameScreen(List<IPlayer> players)
        {
            _renderer.RenderBoard();
        }
    }
}
