using System.Collections.Generic;
using System.Threading.Tasks;
using GeocodingApp.Models;

namespace GeocodingApp.Services
{
    public interface IGeocodingService
    {
        Task<List<LocationResult>> GetCoordinatesAsync(string location);
    }
}