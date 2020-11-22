using SearchEnginePositionFinder.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Net;
using System.Threading.Tasks;

namespace SearchEnginePositionFinderTest.Models
{
    [TestClass]
    public class SearchEngineReaderTest
    {
        TestHelper TestHelp = new TestHelper();

        [TestMethod]
        public void SendCommandToSearchEngine_SearchResultsIsReturned()
        {
            bool resultReturned = false;
            SearchEngineReader searchEngineReader = new SearchEngineReader(TestHelp.SearchSite, TestHelp.SearchEngine);

            string result = searchEngineReader.GetSearchEngineResults();

            if (!String.IsNullOrEmpty(result))
            {
                resultReturned = true;
            }

            Assert.AreEqual(true, resultReturned);
        }
    }
}
