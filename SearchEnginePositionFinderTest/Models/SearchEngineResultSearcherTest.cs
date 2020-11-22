using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Text.RegularExpressions;
using SearchEnginePositionFinder.Models;
using System.Collections.Generic;
using System.Linq;

namespace SearchEnginePositionFinderTest.Models
{
    [TestClass]
    public class SearchEngineResultSearcherTest
    {
        TestHelper TestHelp = new TestHelper();

        [TestMethod]
        public void ReadTestFile_ReturnTestFilesText()
        {
            bool fileRead = false;
            string fileResults = File.ReadAllText(TestHelp.GetHtmlResultsTestFileDirectory());

            if (!String.IsNullOrEmpty(fileResults))
            {
                fileRead = true;
            }

            Assert.AreEqual(true, fileRead);
        }


        [TestMethod]
        public void FindMatchWithRegex_MatchSuccessIsReturned()
        {
            string fileResults = File.ReadAllText(TestHelp.GetHtmlResultsTestFileDirectory());

            Match matchResult = Regex.Match(fileResults, TestHelp.URLExpression);

            Assert.AreEqual(true, matchResult.Success);
        }

        [TestMethod]
        public void FindAllMatchesWithRegex_ReturnNumberOfMatches()
        {
            int expectedNumberOfMatches = 84;
            string fileResults = File.ReadAllText(TestHelp.GetHtmlResultsTestFileDirectory());

            MatchCollection matchResult = Regex.Matches(fileResults, TestHelp.URLExpression);

            Assert.AreEqual(expectedNumberOfMatches, matchResult.Count);
        }


        [TestMethod]
        public void FindPositionOfTheSearchSiteInTheList_PositionListSizeIsReturned()
        {
            IEnumerable<string> searchPlace;
            IEnumerable<string> expectedSearchPlacement = new List<string>( new [] { "11" });

            string fileResults = File.ReadAllText(TestHelp.GetHtmlResultsTestFileDirectory());

            SearchEngineResultSearcher searchEngineResultSearcher = new SearchEngineResultSearcher(TestHelp.SearchURL, fileResults, TestHelp.SearchEngine);
            searchPlace = searchEngineResultSearcher.FindPositionOfSearchString();

            Assert.IsTrue(expectedSearchPlacement.SequenceEqual(searchPlace));
        }
    }
}
