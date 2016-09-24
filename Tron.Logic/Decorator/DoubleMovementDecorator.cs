using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tron.Logic.GameLogic;

namespace Tron.Logic.Decorator
{
    public class DoubleMovementDecorator : MovementDecorator
    {
        public DoubleMovementDecorator(IMovement movement) : base(movement)
        {
        }

        public override void Prepare()
        {
            _movement.Prepare();
            foreach (var magnitude in _movement.movementMagnitudes.magnitudes)
            {
                _movement.movementMagnitudes.addMagnitude(magnitude);
            }
        }
    }
}
