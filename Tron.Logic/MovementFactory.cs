using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tron.Logic.GameLogic;
using Tron.Logic.ParserService;

namespace Tron.Logic
{
    public class MovementFactory
    {
        private Dictionary<string, Type> _movementDictionary;
        public MovementFactory()
        {
            _movementDictionary = MovementsAssembly.Load();
        }

        public IMovement GetMovement(string identifier){
            if (!_movementDictionary.ContainsKey(identifier))
            {
                throw new Exception("unknown movement identifier");
            }
            var type = _movementDictionary[identifier];
            return (IMovement) Activator.CreateInstance(type);
        }
    }
}
