using System;
using System.Net;


namespace SearchEnginePositionFinder.Models
{
    /// <summary>
    /// Class for communication with the search engine
    /// </summary>
    public class SearchEngineReader
    {
        private string searchString = "";
        private SearchEngine searchEngine;
        
        public SearchEngineReader(string searchString, SearchEngine searchEngine)
        {
            this.searchString = searchString;
            this.searchEngine = searchEngine;
        }

        /// <summary>
        /// Get the result string from the search engine
        /// </summary>
        /// <param name="searchString"></param>
        /// <returns>Search result string</returns>
        public string GetSearchEngineResults()
        {
            string searchResult = "";

            // Replace spaces with "+" to format the string correctly for the URL search request
            string formattedString = searchString.Replace(" ", "+");

            using (WebClient webClient = new WebClient())
            {
                searchResult = webClient.DownloadString(searchEngine.URLQuery + formattedString);
            }

            return searchResult;
        }
    }
}
