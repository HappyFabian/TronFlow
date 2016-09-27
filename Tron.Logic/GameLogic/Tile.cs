using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tron.Logic.GameLogic
{
    public class Tile : ITile
    {
        private char _value;

        public char value
        {
            get{return _value;}
            set{_value = value; }
        }
    }
}
