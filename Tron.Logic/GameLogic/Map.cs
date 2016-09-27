using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tron.Logic.GameLogic
{
    public class Map : IMap
    {
        private ITile _defaultTile;
        private ITile[,] _mapArray;

        public ITile defaultTile
        {
            get{ return _defaultTile;  }
            set{ _defaultTile = value; }
        }

        public ITile[,] mapArray
        {
            get{ return _mapArray; }
            set{ _mapArray = value; }
        }

        public void markTile(ICoordinate coordinate, ITile newTile)
        {
            mapArray[coordinate.coordinateX, coordinate.coordinateY] = newTile;
        }


        public void Prepare(ICoordinate size)
        {
            mapArray = new Tile[size.coordinateX, size.coordinateY];
            for(int i = 0; i < size.coordinateX; i++)
            {
                for(int j = 0; j < size.coordinateY; j++)
                {
                    mapArray[i, j] = defaultTile;
                }
            }
        }

        public ITile returnTile(ICoordinate coordinate)
        {
            return mapArray[coordinate.coordinateX , coordinate.coordinateY];
        }
    }
}
