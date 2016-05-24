using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tron.Logic.GameLogic;

namespace Tron.Logic.Movements
{
    public class Down : IMovement
    {
        public List<IMagnitude> ReturnMagnitudes()
        {
            var magnitudes = new List<IMagnitude>();
            magnitudes.Add(new Magnitude(0, -1));
            return magnitudes;
        }


        public string GetIdentifier()
        {
            return "abajo";
        }

        public string PlayerName{ get; set; }
    }
}
