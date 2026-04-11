using System.Collections.Generic;

namespace GeocodingApp.Models
{
    public class GeocodeResponse
    {
        public string Status { get; set; }
        public List<Result> Results { get; set; }
    }

    public class Result
    {
        public string Formatted_Address { get; set; }
        public Geometry Geometry { get; set; }
    }

    public class Geometry
    {
        public Location Location { get; set; }
    }

    public class Location
    {
        public double Lat { get; set; }
        public double Lng { get; set; }
    }
}