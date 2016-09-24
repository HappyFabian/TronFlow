using System;
using System.Collections.Generic;
using System.Data.Common;
using Tron.Logic.GameLogic;
using Tron.Logic.Movements;

namespace Tron.Logic.ParserService
{
    public class Parser : IParser
    {
        
        public readonly IReader _reader;
        private readonly MovementFactory _factory;
        public Parser(IReader reader, MovementFactory factory)
        {
            _reader = reader;
            _factory = factory;
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
            var movement = _factory.GetMovement(movementIdentifier); 
            return movement;
        }
    }
}
