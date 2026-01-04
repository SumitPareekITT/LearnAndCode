using System;
using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace TumblrImageFetcher
{
    public static class TumblrPostHelper
    {
        public static void PrintImages(JObject data, int start, int end)
        {
            JArray posts = (JArray)data["posts"];

            for (int i = start - 1; i < end && i < posts.Count; i++)
            {
                JObject post = (JObject)posts[i];
                List<string> images = GetHighestQualityImages(post);

                if (images.Count > 0)
                {
                    Console.WriteLine($"{i + 1}.");
                    foreach (string img in images)
                    {
                        Console.WriteLine($"   {img}");
                    }
                }
            }
        }

        private static List<string> GetHighestQualityImages(JObject post)
        {
            List<string> images = new List<string>();

            if (post["type"]?.ToString() == "photo")
            {
                foreach (var photo in post["photos"] ?? new JArray())
                {
                    string imageUrl =
                        photo["photo-url-1280"]?.ToString() ??
                        photo["photo-url-500"]?.ToString() ??
                        photo["photo-url-400"]?.ToString();

                    if (!string.IsNullOrEmpty(imageUrl))
                        images.Add(imageUrl);
                }
            }

            return images;
        }
    }
}
