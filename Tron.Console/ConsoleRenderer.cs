using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tron.Logic.GameLogic;

namespace Tron.Console
{
    public class ConsoleRenderer : IRenderer
    {
        private int _width;
        private int _height;

        public void SetBoardSize(int width, int height)
        {
            _width = width;
            _height = height;
        }
        public void RenderBoard()
        {
            System.Console.Clear();
            System.Console.WriteLine();
            for (int i = 0; i < _width; i++)
            {
                for (int j = 0; j < _height; j++)
                {
                    System.Console.Write("---");
                }
                System.Console.WriteLine();
                for (int j = 0; j < _height; j++)
                {
                    System.Console.Write("|" + "  ");
                    if(j + 1 == _height)
                        System.Console.Write( "|");
                }
                System.Console.WriteLine();
                if (i + 1 == _width)
                {
                    for (int j = 0; j < _height; j++)
                    {
                        System.Console.Write("---");
                    }
                    System.Console.WriteLine();
                }
            }
            System.Console.WriteLine("Press Enter to execute next step");
            System.Console.Read();
        }

        public void Menu()
        {
            System.Console.WriteLine("1. Begin");
            System.Console.WriteLine("2. Exit");
        }

        public void AddPlayers()
        {
            System.Console.WriteLine("Write new player name and enter to add write 'done' to finish");
        }

        public void ListPlayers(List<IPlayer> players)
        {
            System.Console.WriteLine("The players in this game are:");
            foreach (var player in players)
            {
                System.Console.WriteLine("-" + player.playerName);
            }
        }
    }
}
