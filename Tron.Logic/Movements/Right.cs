using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tron.Logic.GameLogic;

namespace Tron.Logic.Movements
{
    public class Right : IMovement
    {
        public List<IMagnitude> ReturnMagnitudes()
        {
            var magnitudes = new List<IMagnitude>();
            magnitudes.Add(new Magnitude(1, 0));
            return magnitudes;
        }


        public string GetIdentifier()
        {
            return "derecha";
        }

        public string PlayerName { get; set; }
    }
}
