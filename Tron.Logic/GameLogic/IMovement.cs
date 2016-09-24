using System.Collections.Generic;

namespace Tron.Logic.GameLogic
{
    public interface IMovement
    {
        IMagnitudeComposite ReturnMagnitudes();
        string GetIdentifier();
        string PlayerName { get; set; }
    }
}
