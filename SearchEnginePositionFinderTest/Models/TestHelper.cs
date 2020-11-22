using System.IO;
using SearchEnginePositionFinder.Models;

namespace SearchEnginePositionFinderTest.Models
{
    public class TestHelper
    {
        public string SearchEngineAddress = "https://www.google.co.uk/search?num=100&q=";
        public string SearchSite = "land registry search";
        private string testDirectory = Directory.GetCurrentDirectory() + "/../../..";
        private string testFilesFolder = "TestFiles";
        private string htmlResultsTestFile = "TestFile.txt";
        public string URLExpression = "<div class=\"[a-zA-Z0-9 ]+\">www.[a-zA-Z0-9]+.";
        public string SearchURL = "www.infotrack.co.uk";
        public SearchEngine SearchEngine = new SearchEngineGoogle();

        private string GetTestFilesDirectory()
        {
            return testDirectory + "/" + testFilesFolder;
        }

        public string GetHtmlResultsTestFileDirectory()
        {
            return GetTestFilesDirectory() + "/" +  htmlResultsTestFile;
        }
    }
}
