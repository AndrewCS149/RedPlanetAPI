using RedPlanetAPI.Data;

namespace RedPlanetAPI.Interfaces
{
    public interface IMarsRoverPhoto
    {
        /// <summary>
        /// API call that retrieves a specific rover's mission manifest from NASA's Mars Rover API
        /// </summary>
        /// <param name="rover">The specific rover to fetch the manifest for</param>
        /// <returns>MarsRoverManifest.Response object</returns>
        Task<MarsRoverManifest.Response> GetMarsRoverManifest(string rover);

        /// <summary>
        /// API call that retrieves a specific rover's photos from the NASA's Mars Rover API
        /// </summary>
        /// <param name="urlParams">The url paramters to pass into the API call</param>
        /// <returns>MarsRoverPhoto.Response object</returns>
        Task<MarsRoverPhoto.Response> GetRoverPhotos(MarsRoverPhoto.Params? urlParams);
    }
}
