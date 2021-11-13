using RedPlanetAPI.Data;

namespace RedPlanetAPI.Interfaces
{
    public interface IMarsRoverPhoto
    {
        Task<MarsRoverPhoto.Response> GetRoverPhotos(MarsRoverPhoto.Params? urlParams);
        Task<MarsRoverManifest.Response> GetMarsRoverManifest(string rover);
    }
}
