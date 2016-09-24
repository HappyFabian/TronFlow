using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tron.Logic.GameLogic
{
    public class Coordinate : ICoordinate
    {
        public int coordinateX
        {
            get { return coordinateX; }
            set { coordinateX = value;}
        }

        public int coordinateY
        {
            get { return coordinateY; }
            set { coordinateY = value;}
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
