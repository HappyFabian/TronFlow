using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tron.Logic.GameLogic
{
    public class Magnitude : IMagnitude
    {
        ICoordinate coordinates;

        public Magnitude(ICoordinate coordinate)
        {
            coordinates = coordinate;
        }

        public ICoordinate returnValues()
        {
            return coordinates;
        }
    }
}
