namespace RedPlanetAPI.Data
{
    public class MarsRoverPhoto
    {
        public class Params
        {
            public string? Sol { get; set; }
            public string? Camera { get; set; }
            public string? RoverName { get; set; }
            public Params()
            {
                Sol = "&sol=1";
                RoverName = "curiosity";
            }
        }

        public class Response
        {
            public Photos[]? Photos { get; set; }
        }

        public class Photos
        {
            public int Sol { get; set; }
            public string? Img_src { get; set; }
        }
    }
}
