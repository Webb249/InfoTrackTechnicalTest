using Microsoft.AspNetCore.Mvc.RazorPages;
using SearchEnginePositionFinder.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SearchEnginePositionFinder
{
    public class IndexModel : PageModel
    {
        public string SearchPhrase { get; set; }
        public string SearchSite { get; set; }
        public string SearchEngine { get; set; }
        public string Result { get; set; }        

        public void OnGet()
        {
        }

        /// <summary>
        /// Finds the position of the SearchSite in the search engines query
        /// </summary>
        public async Task RunGetURLPositionAsync()
        {
            SearchEngine searchEngine = SearchEnigineType.GetSearchEngine(SearchEngine);
            SearchEngineReader searchEngineReader = new SearchEngineReader(SearchPhrase, searchEngine);
            
            string searchResult = await Task.Run( ()=> { return searchEngineReader.GetSearchEngineResults(); });

            SearchEngineResultSearcher searchEngineResultSearcher = new SearchEngineResultSearcher(SearchSite, searchResult, searchEngine);

            IEnumerable<string> searchPositions = searchEngineResultSearcher.FindPositionOfSearchString();

            Result = string.Join(",", searchPositions);
        }
    }
}
