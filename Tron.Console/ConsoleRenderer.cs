using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                if (i + 1 == _height)
                {
                    for (int j = 0; j < _height; j++)
                    {
                        System.Console.Write("---");
                    }
                    System.Console.WriteLine();
                }
            }
            System.Console.Read();
        }
    }
}
