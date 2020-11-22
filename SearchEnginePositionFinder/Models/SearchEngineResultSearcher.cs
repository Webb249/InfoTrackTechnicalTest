using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace SearchEnginePositionFinder.Models
{
    /// <summary>
    /// Class to contain the functions to manipulate the information received from the search engine
    /// </summary>
    public class SearchEngineResultSearcher
    {
        private string searchSite = "";
        private string searchResults = "";
        private SearchEngine searchEngine;

        public SearchEngineResultSearcher(string searchSite, string searchResults, SearchEngine searchEngine)
        {
            this.searchSite = searchSite;
            this.searchResults = searchResults;
            this.searchEngine = searchEngine;
        }

        /// <summary>
        /// Get the positions of the searchString inside the resultString
        /// </summary>
        /// <returns>Positions of the search string</returns>
        public IEnumerable<string> FindPositionOfSearchString()
        {
            string websiteName = Utilities.GetDomainNameFromURL(searchSite);

            //First check the websiteName exists inside the searchResult
            if (!searchResults.Contains(websiteName)) 
            {
                yield return "0";
                yield break;
            }

            MatchCollection matchResult = Regex.Matches(searchResults, searchEngine.WebsiteRegex);

            int count = 1;
            foreach (Match match in matchResult)
            {
                if (match.ToString().Contains(websiteName))
                {
                    yield return count.ToString();
                }

                count++;
            }
        }
    }
}
