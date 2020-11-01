using System;
using Entities.Common;

namespace Entities.Route
{
    public class Waypoint: BaseEntity<long>
    {
        public double Lat { get; set; }
        public double Lon { get; set; }
        public DateTime Time { get; set; }
        public int Height { get; set; }
    }
}