using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tron.Logic.GameLogic
{
    public class Map : IMap
    {
        public ITile[,] mapArray
        {
            get{ return mapArray; }
            set{ mapArray = value; }
        }

        public void markTile(ICoordinate coordinate, ITile newTile)
        {
            mapArray[coordinate.coordinateX, coordinate.coordinateY] = newTile;
        }


        public void Prepare(ICoordinate size)
        {
            mapArray = new ITile[size.coordinateX, size.coordinateY];
        }

        public ITile returnTile(ICoordinate coordinate)
        {
            return mapArray[coordinate.coordinateX , coordinate.coordinateY];
        }
    }
}
