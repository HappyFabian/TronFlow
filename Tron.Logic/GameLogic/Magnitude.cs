using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tron.Logic.GameLogic
{
    class Magnitude : IMagnitude
    {
        ICoordinate coordinates;

        Magnitude(ICoordinate coordinate)
        {
            coordinates = coordinate;
        }

        public ICoordinate returnValues()
        {
            return coordinates;
        }
    }
}
