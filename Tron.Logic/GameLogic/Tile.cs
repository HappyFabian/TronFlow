using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tron.Logic.GameLogic
{
    public class Tile : ITile
    {
        public Color color { get; set; }
        public Tile(Color color)
        {
            this.color = color;
        }
    }
}
