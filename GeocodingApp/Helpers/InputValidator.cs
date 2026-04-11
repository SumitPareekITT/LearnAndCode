using System;

namespace GeocodingApp.Helpers
{
    public static class InputValidator
    {
        public static void ValidateLocation(string input)
        {
            if (string.IsNullOrWhiteSpace(input))
                throw new ArgumentException("Location cannot be empty");

            if (input.Length < 2)
                throw new ArgumentException("Location is too short");
        }
    }
}