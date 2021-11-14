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

/*
 {
    "rover": {
        "id": 5,
        "name": "Curiosity",
        "landing_date": "2012-08-06",
        "launch_date": "2011-11-26",
        "status": "active",
        "max_sol": 3292,
        "max_date": "2021-11-09",
        "total_photos": 525710,
        "cameras": [
            {
                "name": "FHAZ",
                "full_name": "Front Hazard Avoidance Camera"
            },
            {
                "name": "NAVCAM",
                "full_name": "Navigation Camera"
            },
            {
                "name": "MAST",
                "full_name": "Mast Camera"
            },
            {
                "name": "CHEMCAM",
                "full_name": "Chemistry and Camera Complex"
            },
            {
                "name": "MAHLI",
                "full_name": "Mars Hand Lens Imager"
            },
            {
                "name": "MARDI",
                "full_name": "Mars Descent Imager"
            },
            {
                "name": "RHAZ",
                "full_name": "Rear Hazard Avoidance Camera"
            }
        ]
    }
}
 */