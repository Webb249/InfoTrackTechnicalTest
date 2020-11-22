
namespace SearchEnginePositionFinder.Models
{
    /// <summary>
    /// Google information for the queary and regex of the results
    /// </summary>
    public class SearchEngineGoogle : SearchEngine
    {
        private string name = "Google";
        private string urlQuery = "https://www.google.co.uk/search?num=100&q=";
        private string websiteRegex = "<div class=\"[a-zA-Z0-9 ]+\">www.[a-zA-Z0-9]+.";

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
