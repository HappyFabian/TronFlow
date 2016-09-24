using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tron.Logic.GameLogic
{
    public interface IMagnitudeComposite : IMagnitude
    {
        List<IMagnitude> magnitudes { get; set; }

        void addMagnitude(IMagnitude magnitude);
        void removeMagnitude(IMagnitude magnitude);

    }
}
