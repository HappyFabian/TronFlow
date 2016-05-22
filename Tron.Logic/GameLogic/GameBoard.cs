using System;

namespace Tron.Logic.GameLogic
{
    public class GameBoard : Board
    {
      
        public GameBoard(int boardWidth, int boardHeight, object initialValue)
        {
            Map = new object[boardWidth,boardHeight];
            InitializeMap(initialValue);
        }

        public override void InitializeMap(object value)
        {
            for (int x = 0; x < Map.GetLength(0); x++)
            {
                for (int y = 0; y < Map.GetLength(1); y++)
                {
                    Map[x, y] = value;
                }
            }
        }

        public override void MarkSpot(int x_coor, int y_coor, object value)
        {
            Map[x_coor, y_coor] = value;
        }
    }
}
