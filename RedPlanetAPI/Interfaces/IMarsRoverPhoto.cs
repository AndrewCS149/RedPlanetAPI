using RedPlanetAPI.Data;

namespace RedPlanetAPI.Interfaces
{
    public interface IMarsRoverPhoto
    {
        Task<MarsRoverPhoto.Response> GetRoverPhotos();
    }
}
