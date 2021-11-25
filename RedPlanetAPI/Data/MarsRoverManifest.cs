namespace RedPlanetAPI.Data
{
    public class MarsRoverManifest
    {
        public class Response
        {
            public Rover Rover { get; set; }
        }
        public class Rover
        {
            public string? Name { get; set; }
            public string? Landing_date { get; set; }
            public string? Launch_date { get; set; }
            public string? Status { get; set; }
            public int Max_sol { get; set; }
            public string? Max_date { get; set; }
            public int Total_photos { get; set; }
            public Camera[]? Cameras { get; set; }
        }

        public class Camera
        {
            public string? Name { get; set; }
            public string? Full_name { get; set; }
        }
    }
}
