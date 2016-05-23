using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tron.Logic.GameLogic
{
    public abstract class Board : IBoard
    {
        public object[,] Map;

        public abstract void InitializeMap(object value);

        public abstract object[,] ReturnMap();

        public abstract void MarkSpot(int xCoordinate, int yCoordinate, object value);
    }
}
