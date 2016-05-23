using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;
using Tron.Logic.GameLogic;

namespace Tron.Specs
{
    [Binding]
    public class GameBoard_InitializeBoard_Steps
    {
        [Given(@"I have width (.*), height (.*), String '(.*)'")]
        public void GivenIHaveWidthHeightString(int p0, int p1, string p2)
        {
            ScenarioContext.Current.Add("Width", p0);
            ScenarioContext.Current.Add("Height", p1);
            ScenarioContext.Current.Add("InitialValue", p2);
        }

        [When(@"I create a new GameBoard")]
        public void WhenICreateANewGameBoard()
        {
            int Width = ScenarioContext.Current.Get<int>("Width");
            int Height = ScenarioContext.Current.Get<int>("Height");
            string InitialValue = ScenarioContext.Current.Get<string>("InitialValue");

            IBoard gBoard = new GameBoard(Width,Height,InitialValue);

            ScenarioContext.Current.Add("gameBoard", gBoard);
        }
        
        [Then(@"each tile in the gameboard Should be '(.*)'")]
        public void ThenEachTileInTheGameboardShouldBe(string p0)
        {
            var gameBoard = ScenarioContext.Current.Get<Board>("gameBoard");
            bool expectedResult = true;
            bool actualResult = true;

            foreach(var i in gameBoard.Map)
            {
                if (!i.Equals(p0))
                {
                    actualResult = false;
                }
            }

            Assert.AreEqual(expectedResult, actualResult,"The Board was not generated properly.");
        }
    }

}
