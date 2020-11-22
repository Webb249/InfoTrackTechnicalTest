
using System.Text.RegularExpressions;

namespace SearchEnginePositionFinder.Models
{
    public class Utilities
    {
        private static string regexPattern = "[a-z]+.[a-z]+.?";

        /// <summary>
        /// Remove the start and end of the URL
        /// </summary>
        /// <param name="url"></param>
        /// <returns>Website name</returns>
        public static string GetDomainNameFromURL(string url)
        {
            string name = "";

            // Check URL matchs expected format of www.example.co.uk
            if (Regex.IsMatch(url, regexPattern))
            {
                try
                {
                    name = url.Substring(url.IndexOf('.') + 1);
                    name = name.Substring(0, name.IndexOf('.'));
                }
                catch 
                {
                    return url;
                }
            }
            else
            {
                name = url;
            }
    
            return name;
        }
    }
}
