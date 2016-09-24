using System.Collections.Generic;

namespace Tron.Logic.GameLogic
{
    public interface IMovement
    {
        void Prepare();
        IMagnitudeComposite movementMagnitudes { get; set; }
        IMagnitudeComposite ReturnMagnitudes();
        string GetIdentifier();
    }
}
