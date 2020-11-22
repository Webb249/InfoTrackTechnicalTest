using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SearchEnginePositionFinder.Models
{
    public class SearchEnigineType
    {
        public enum SearchEngineTypes
        {
            Google,
            Bing
        }

        /// <summary>
        /// Get the SearchEngine depending on the searchEngineName given
        /// </summary>
        /// <param name="searchEngineName"></param>
        /// <returns>SearchEngine type</returns>
        public static SearchEngine GetSearchEngine(string searchEngineName)
        {
            SearchEngineTypes searchEngineValue = (SearchEngineTypes)Enum.Parse(typeof(SearchEngineTypes), searchEngineName, true);

            switch (searchEngineValue)
            {
                case SearchEngineTypes.Google:
                    return new SearchEngineGoogle();
                case SearchEngineTypes.Bing:
                    return new SearchEngineBing();
                default:
                    return null;
            }
        }
    }
}
