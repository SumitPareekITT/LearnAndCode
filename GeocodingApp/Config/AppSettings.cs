namespace GeocodingApp.Config
{
    public class AppSettings
    {
        public GoogleApiSettings GoogleApi { get; set; }
    }

    public class GoogleApiSettings
    {
        public string ApiKey { get; set; }
    }
}