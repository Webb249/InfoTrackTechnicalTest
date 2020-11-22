
namespace SearchEnginePositionFinder.Models
{
    /// <summary>
    /// Factory class for the creation of the data of many search engines
    /// </summary>
    public abstract class SearchEngine
    {
        public abstract string Name { get; }
        public abstract string URLQuery { get; }
        public abstract string WebsiteRegex { get; }
    }
}
