using System;
using System.IO;
using System.Text.Json;
using System.Threading.Tasks;
using GeocodingApp.Config;
using GeocodingApp.Helpers;
using GeocodingApp.Services;

class Program
{
    static async Task Main(string[] args)
    {
        try
        {
            var configText = File.ReadAllText("appsettings.json");
            var config = JsonSerializer.Deserialize<AppSettings>(configText);

            var service = new GeocodingService(config.GoogleApi.ApiKey);

            Console.Write("Enter location: ");
            var input = Console.ReadLine();

            InputValidator.ValidateLocation(input);

            var results = await service.GetCoordinatesAsync(input);

            Console.WriteLine("\nResults:\n");

            foreach (var r in results)
            {
                Console.WriteLine($"Address: {r.Address}");
                Console.WriteLine($"Latitude: {r.Latitude}");
                Console.WriteLine($"Longitude: {r.Longitude}");
                Console.WriteLine("---------------------------");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }
    }
}