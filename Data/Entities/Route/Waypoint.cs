using System;

namespace Data.Entities.Route
{
    public class Waypoint
    {
        public long Id { get; set; }
        public double Lat { get; set; }
        public double Lon { get; set; }
        public DateTime Time { get; set; }
        public int Height { get; set; }
    }
}