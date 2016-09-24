using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tron.Logic.GameLogic
{
    public class Magnitude : IMagnitude
    {
        public int XMagnitude { set;  get; }
        public int YMagnitude { set;  get; }

        public Magnitude(int xmagnitude, int ymagnitude)
        {
            XMagnitude = xmagnitude;
            YMagnitude = ymagnitude;
        }

        public Tuple<int, int> returnValues()
        {
            return new Tuple<int, int>(XMagnitude, YMagnitude);
        }
    }
}
