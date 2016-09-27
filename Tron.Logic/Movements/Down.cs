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
        private IMagnitudeComposite _movementMagnitudes;

        public IMagnitudeComposite movementMagnitudes
        {
            get { return _movementMagnitudes; }
            set { _movementMagnitudes = value; }
        }

        public void Prepare()
        {
            movementMagnitudes = new Magnitudes();
            movementMagnitudes.addMagnitude(new Magnitude(new Coordinate(0, -1)));
        }

        public string GetIdentifier()
        {
            return "DOWN";
        }

        public IMagnitudeComposite ReturnMagnitudes()
        {
            return movementMagnitudes;
        }


    }
}
