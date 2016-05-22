using System.IO;
using TechTalk.SpecFlow;

namespace Tron.Specs
{
    [Binding]
    public class FileReaderTestsSteps
    {
        [Given]
        public void GivenAnExistingFile_P0_ThatStillHasLines(string filePathName)
        {
            ScenarioContext.Current.Pending();
            var streamReader = new StreamReader(@"Tron.Specs\TestFile.txt",true);
            ScenarioContext.Current.Add("File",streamReader);
        }

        [When]
        public void WhenCalledTheFunctionGetNextLine()
        {
            var file = ScenarioContext.Current["File"];
            ScenarioContext.Current.Pending();
        }
        
        [Then]
        public void ThenTheFunctionShouldReturnAString()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
