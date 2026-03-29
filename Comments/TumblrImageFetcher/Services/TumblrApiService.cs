using System.Net.Http;
using System.Threading.Tasks;
using TumblrImageFetcher.Helpers;

namespace TumblrImageFetcher.Services
{
    // Service class responsible for communicating with Tumblr API
    public static class TumblrApiService
    {
        public static async Task<string> FetchBlogData(string url)
        {
            try
            {
                using HttpClient client = new HttpClient();
                string response = await client.GetStringAsync(url);

                // Tumblr API v1 returns JSONP
                return JsonHelper.ExtractJsonFromJsonp(response);
            }
            catch
            {
                return null;
            }
        }
    }
}
