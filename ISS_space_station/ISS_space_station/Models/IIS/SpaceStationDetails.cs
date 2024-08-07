namespace ISS_space_station.Models.IIS
{
    public class SpaceStationDetails
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public double Altitude { get; set; }
        public double Velocity { get; set; }
        public string Visibility { get; set; }
        public double Footprint { get; set; }
        public double Timestamp { get; set; }
        public double Daynum { get; set; }
        public double SolarLat { get; set; }
        public double SolarLong { get; set; }
        public string Units { get; set; }

    }
}
