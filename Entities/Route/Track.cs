using System.Collections;
using System.Collections.Generic;
using Entities.Common;

namespace Entities.Route
{
    public class Track: BaseEntity<long>
    {
        public ICollection<Waypoint> Waypoints { get; set; }
    }
}