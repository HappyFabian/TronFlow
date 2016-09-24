using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tron.Logic.GameLogic;

namespace Tron.Logic.Decorator
{
    public abstract class MovementDecorator : IMovement
    {
        private IMovement _movement;

        public MovementDecorator(IMovement movement)
        {
            _movement = movement;
        }
        public void Prepare()
        {
            _movement.Prepare();
        }

        public IMagnitudeComposite movementMagnitudes
        {
            get
            {
                return _movement.movementMagnitudes;
            }
            set
            {
                _movement.movementMagnitudes = value;
            }
        }

        public IMagnitudeComposite ReturnMagnitudes()
        {
            return _movement.ReturnMagnitudes();
        }

        public string GetIdentifier()
        {
            return _movement.GetIdentifier();
        }
    }
}
