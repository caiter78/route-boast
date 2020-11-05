using System;
using System.Collections.Generic;

namespace Data.Entities.Route
{
    public class Route
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int LikeCount { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public virtual ICollection<Track> Tracks { get; set; }
    }
}