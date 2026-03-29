namespace TumblrImageFetcher.Helpers
{
    public static class RangeHelper
    {
        public static bool TryParseRange(string input, out int start, out int end)
        {
            start = end = 0;

            if (string.IsNullOrWhiteSpace(input))
                return false;

            string[] parts = input.Split('-');
            return parts.Length == 2 &&
                   int.TryParse(parts[0], out start) &&
                   int.TryParse(parts[1], out end) &&
                   start > 0 &&
                   end >= start;
        }
    }
}
