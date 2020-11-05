using System.Collections.Generic;

namespace Entities.Route
{
    public class Track
    {
        public long Id { get; set; }
        public virtual ICollection<Waypoint> Waypoints { get; set; }
    }
}