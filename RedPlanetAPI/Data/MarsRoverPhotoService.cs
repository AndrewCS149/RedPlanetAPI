using RedPlanetAPI.Interfaces;

namespace RedPlanetAPI.Data
{
    public class MarsRoverPhotoService : IMarsRoverPhoto
    {
        private readonly IConfiguration _config;
        public MarsRoverPhotoService(IConfiguration config)
        {
            _config = config;
        }

        public async Task<MarsRoverManifest.Response> GetMarsRoverManifest(string rover)
        {
            HttpClient client = new HttpClient();
            string url = $"https://api.nasa.gov/mars-photos/api/v1/rovers/{rover}/?manifests&api_key={_config["NASA_API_KEY"]}";
            HttpResponseMessage HTTPresponse = await client.GetAsync(url);

            return HTTPresponse.IsSuccessStatusCode ? await HTTPresponse.Content.ReadFromJsonAsync<MarsRoverManifest.Response>() : null;
        }
        public async Task<MarsRoverPhoto.Response> GetRoverPhotos(MarsRoverPhoto.Params urlParams)
        {
            HttpClient client = new HttpClient();
            string url = $"https://api.nasa.gov/mars-photos/api/v1/rovers/{urlParams.RoverName}/photos?{urlParams.Sol}{urlParams.Camera}&api_key={_config["NASA_API_KEY"]}";
            HttpResponseMessage HTTPresponse = await client.GetAsync(url);

            return HTTPresponse.IsSuccessStatusCode ? await HTTPresponse.Content.ReadFromJsonAsync<MarsRoverPhoto.Response>() : null;
        }
    }
}
