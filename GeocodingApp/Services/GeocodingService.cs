using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using GeocodingApp.Models;

namespace GeocodingApp.Services
{
    public class GeocodingService : IGeocodingService
    {
        private readonly string _apiKey;
        private readonly HttpClient _httpClient;

        public GeocodingService(string apiKey)
        {
            _apiKey = apiKey;
            _httpClient = new HttpClient();
        }

        public async Task<List<LocationResult>> GetCoordinatesAsync(string location)
        {
            var url = $"https://maps.googleapis.com/maps/api/geocode/json?address={location}&key={_apiKey}";

            var response = await _httpClient.GetAsync(url);

            if (!response.IsSuccessStatusCode)
                throw new Exception("API request failed");

            var json = await response.Content.ReadAsStringAsync();
            var data = JsonSerializer.Deserialize<GeocodeResponse>(json);

            if (data.Status != "OK")
                throw new Exception($"API Error: {data.Status}");

            var results = new List<LocationResult>();

            foreach (var item in data.Results)
            {
                results.Add(new LocationResult
                {
                    Address = item.Formatted_Address,
                    Latitude = item.Geometry.Location.Lat,
                    Longitude = item.Geometry.Location.Lng
                });
            }

            return results;
        }
    }
}