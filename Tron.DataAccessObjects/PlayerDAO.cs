using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tron.DataAccessObjects
{
    public class PlayerDAO
    {
        public string Name { get; set; }
        public string Color { get; set; }

        public PlayerDAO(string name, string color)
        {
            Name = name;
            Color = color;
        }
    }
}
