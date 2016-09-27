using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tron.Logic.GameLogic
{
    public class Coordinate : ICoordinate
    {
        private int _coordinateX;
        private int _coordinateY;
        public int coordinateX
        {
            get { return _coordinateX; }
            set { _coordinateX = value;}
        }

        public int coordinateY
        {
            get { return _coordinateY; }
            set { _coordinateY = value;}
        }

        public Coordinate(int x, int y)
        {
            coordinateX = x;
            coordinateY = y;
        }

        public void updateCoordinate(int x, int y)
        {
            coordinateX = x;
            coordinateY = y;
        }
    }
}
