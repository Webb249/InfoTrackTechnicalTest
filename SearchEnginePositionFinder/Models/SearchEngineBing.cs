
namespace SearchEnginePositionFinder.Models
{
    /// <summary>
    /// Bing information for the queary and regex of the results
    /// </summary>
    public class SearchEngineBing : SearchEngine
    {
        private string name = "Bing";
        private string urlQuery = "https://www.bing.co.uk/search?num=100&q=";
        private string websiteRegex = "www.[a-zA-Z0-9]+."; // TODO FIX REGEX

        public override string Name
        {
            get { return name; }
        }

        public override string URLQuery
        {
            get { return urlQuery; }
        }

        public override string WebsiteRegex
        {
            get { return websiteRegex; }
        }
    }
}
