using System;
using System.Collections.Generic;
using System.Data.Common;
using Tron.Logic.Movements;

namespace Tron.Logic.ParserService
{
    public class Parser : IParser
    {
        private Dictionary<string, Type> _movementDictionary;
        public readonly IReader _reader;
        public Parser(IReader reader)
        {
            _movementDictionary = MovementsAssembly.Load();
            _reader = reader;
        }

        public IMovement GetNextMovement()
        {
            var line = _reader.GetNextLine();
            if (line == null)
            {
                return null;
            }
            var splittedLine = line.Split(':');
            if (splittedLine.Length < 2)
            {
                throw new Exception("Incorrect sentence");
            }
            var player = splittedLine[0];
            var movementIdentifier = splittedLine[1];
            var movement = InstantiateMovement(movementIdentifier);;
            movement.PlayerName = player;
            return movement;
        }

        private IMovement InstantiateMovement(string identifier)
        {
            if (!_movementDictionary.ContainsKey(identifier))
            {
                throw new Exception("unknown movement identifier");
            }
            var type = _movementDictionary[identifier];
            return (IMovement) Activator.CreateInstance(type);
        }
    }
}
