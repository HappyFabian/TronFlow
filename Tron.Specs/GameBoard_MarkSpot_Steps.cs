using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using TechTalk.SpecFlow;
using Tron.Logic.GameLogic;

namespace Tron.Specs
{
    [Binding]
    public class GameBoard_MarkSpot_Steps
    {
        [Given(@"I have a GameBoard of width (.*), height (.*), with initial value of '(.*)'")]
        public void GivenIHaveAGameBoardOfWidthHeightWithInitialValueOf(int p0, int p1, string p2)
        {
            IBoard gameBoard = new GameBoard(p0,p1,p2);
            ScenarioContext.Current.Add("GameBoard", gameBoard);
        }

        [When(@"I mark spot x (.*) y (.*) and spot x (.*) y (.*) with '(.*)'")]
        public void WhenIMarkSpotXYAndSpotXYWith(int p0, int p1, int p2, int p3, string p4)
        {
            var gameBoard = ScenarioContext.Current.Get<Board>("GameBoard");
            ScenarioContext.Current.Remove("GameBoard");

            gameBoard.MarkSpot(p0, p1, p4);
            gameBoard.MarkSpot(p2, p3, p4);


            ScenarioContext.Current.Add("GameBoard",gameBoard);
        }


        [Then(@"Spot x (.*) y (.*) and spot x (.*) y(.*) should be '(.*)'")]
        public void ThenSpotXYAndSpotXYShouldBe(int p0, int p1, int p2, int p3, string p4)
        {
            bool expectedResult = true;
            bool actualResult = true;
            var gameBoard = ScenarioContext.Current.Get<Board>("GameBoard");

            if (!gameBoard.Map[p0, p1].Equals(p4) || !gameBoard.Map[p2, p3].Equals(p4))
            {
                actualResult = false;
            }

            Assert.AreEqual(expectedResult, actualResult, "They were not properly marked");
        }

    }
}
