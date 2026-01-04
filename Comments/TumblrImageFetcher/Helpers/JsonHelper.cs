using System.Text.RegularExpressions;

namespace TumblrImageFetcher.Helpers
{
    public static class JsonHelper
    {
        public static string ExtractJsonFromJsonp(string jsonp)
        {
            // Regex to extract JSON object from JSONP
            var match = Regex.Match(jsonp, @"\{.*\}", RegexOptions.Singleline);
            return match.Success ? match.Value : null;
        }
    }
}
