using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tron.Logic.Movements
{
    public class Up : IMovement
    {
        public List<IMagnitude> ReturnMagnitudes()
        {
            var magnitudes = new List<IMagnitude>();
            magnitudes.Add(new Magnitude(0, 1));
            return magnitudes;
        }

        public string GetIdentifier()
        {
            return "arriba";
        }

        public string PlayerName { get; set; }
    }
}
