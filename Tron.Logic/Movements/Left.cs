using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tron.Logic.Movements
{
    public class Left : IMovement
    {
        public void Move()
        {
            
        }

        public string GetIdentifier()
        {
            return "izquierda";
        }

        public string PlayerName { get; set; }
    }
}
