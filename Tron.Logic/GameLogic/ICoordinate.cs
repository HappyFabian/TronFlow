using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tron.Logic.GameLogic
{
    public interface ICoordinate
    {
        int coordinateX { get; set; }
        int coordinateY { get; set; }

        void updateCoordinate(int x, int y);
    }
}
