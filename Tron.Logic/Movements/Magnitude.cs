using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tron.Logic.Movements
{
    public class Magnitude : IMagnitude
    {
        public int XMagnitude { get; }
        public int YMagnitude { get; }

        public Magnitude(int xmagnitude, int ymagnitude)
        {
            XMagnitude = xmagnitude;
            YMagnitude = ymagnitude;
        }

      
    }
}
