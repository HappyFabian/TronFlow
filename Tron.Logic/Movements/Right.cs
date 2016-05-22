using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tron.Logic.Movements
{
    public class Right : IMovement
    {
        public void Move()
        {
            
        }

        public string GetIdentifier()
        {
            return "derecha";
        }

        public string PlayerName { get; set; }
    }
}
