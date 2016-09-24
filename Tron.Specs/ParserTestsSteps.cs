using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;
using Tron.Logic.Movements;
using Tron.Logic.ParserService;
using Tron.Logic.GameLogic;
using Tron.Logic;

namespace Tron.Specs
{
    [Binding]
    public class ParserTestsSteps
    {
        private Parser _parser;
        public IMovement _movement;
        [Given(@"the input '(.*)'")]
        public void GivenTheInput(string p0)
        {
            _parser = new Parser(new TestReader(p0), new MovementFactory());
        }
        
        [When(@"Input is parsed")]
        public void WhenInputIsParsed()
        {
            _movement = _parser.GetNextMovement();
        }
        
        [Then(@"The function should return a '(.*)' movement and '(.*)' Player")]
        public void ThenTheFunctionShouldReturnAMovementAndPlayer(string p0, string p1)
        {
            Assert.AreEqual(p0, _movement.GetType().Name);
        }

    }

    public class TestReader : IReader
    {
        private readonly string _line;
        public TestReader(string p0)
        {
            _line = p0;
        }

        public void RewindToBeggining()
        {
            
        }

        public string GetNextLine()
        {
            return _line;
        }
    }
}
