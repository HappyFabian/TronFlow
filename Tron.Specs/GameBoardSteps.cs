using System;
using TechTalk.SpecFlow;

namespace Tron.Specs
{
    [Binding]
    public class GameBoardSteps
    {
        [Given(@"I have width (.*), height (.*), String '(.*)'")]
        public void GivenIHaveWidthHeightString(int p0, int p1, string p2)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I press create a new GameBoard")]
        public void WhenIPressCreateANewGameBoard()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"each tile in the gameboard Should be '(.*)'")]
        public void ThenEachTileInTheGameboardShouldBe(string p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
