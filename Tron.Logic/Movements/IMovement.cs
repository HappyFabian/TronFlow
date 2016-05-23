using System.Collections.Generic;

namespace Tron.Logic.Movements
{
    public interface IMovement
    {
        List<IMagnitude> ReturnMagnitudes();
        string GetIdentifier();
        string PlayerName { get; set; }
    }
}
