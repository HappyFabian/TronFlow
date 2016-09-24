using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tron.Logic.GameLogic
{
    public interface IMap
    {
        ITile[,] mapArray { get; set; }
        void Prepare(ICoordinate size);
        void markTile(ICoordinate coordinate, ITile newTile);
        ITile returnTile(ICoordinate coordinate);

    }
}
