using System;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;
using TumblrImageFetcher.Services;
using TumblrImageFetcher.Helpers;

namespace TumblrImageFetcher
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.Write("Enter the Tumblr blog name: ");
            string blogName = Console.ReadLine()?.Trim();

            Console.Write("Enter the range (start-end): ");
            string rangeInput = Console.ReadLine();

            if (!RangeHelper.TryParseRange(rangeInput, out int start, out int end))
            {
                Console.WriteLine("Invalid range format.");
                return;
            }

            string apiUrl = $"https://{blogName}.tumblr.com/api/read/json";

            // Fetch Tumblr blog data using API service
            string json = await TumblrApiService.FetchBlogData(apiUrl);

            if (string.IsNullOrEmpty(json))
            {
                Console.WriteLine("Failed to fetch Tumblr data.");
                return;
            }

            // Parse JSON string into JObject
            JObject data = JObject.Parse(json);

            PrintBlogInfo(data);
            TumblrPostHelper.PrintImages(data, start, end);
        }

        private static void PrintBlogInfo(JObject data)
        {
            Console.WriteLine("\nBlog Info:");
            Console.WriteLine($"Title       : {data["tumblelog"]?["title"]}");
            Console.WriteLine($"Name        : {data["tumblelog"]?["name"]}");
            Console.WriteLine($"Description : {data["tumblelog"]?["description"]}");
            Console.WriteLine($"No of Posts : {data["posts-total"]}\n");
        }
    }
}
