using RedPlanetAPI.Interfaces;

namespace RedPlanetAPI.Data
{
    public class MarsRoverPhotoService : IMarsRoverPhoto
    {
        private readonly IConfiguration _config;
        public MarsRoverPhoto.Response Response { get; set; }

        public MarsRoverPhotoService(IConfiguration config)
        {
            _config = config;
        }

        public async Task<MarsRoverPhoto.Response> GetRoverPhotos()
        {
            HttpClient client = new HttpClient();
            string url = "https://api.nasa.gov/mars-photos/api/v1/rovers/curiosity/photos?sol=100&api_key=" + _config["NASA_API_KEY"];

            HttpResponseMessage HTTPresponse = await client.GetAsync(url);
            if (HTTPresponse.IsSuccessStatusCode)
            {
                Response = await HTTPresponse.Content.ReadFromJsonAsync<MarsRoverPhoto.Response>();
            }

            return Response;
        }
    }
}
