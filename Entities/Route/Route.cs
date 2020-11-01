using System;
using System.Collections.Generic;
using Entities.Common;

namespace Entities.Route
{
    public class Route: BaseEntity<long>
    {
        public string Name { get; set; }
        public int LikeCount { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public ICollection<Track> Tracks { get; set; }
    }
}