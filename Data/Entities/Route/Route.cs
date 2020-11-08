using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Data.Entities.Route
{
    public class Route
    {
        public long Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        
        [Required]
        [Range(1, Int32.MaxValue)]
        public int LikeCount { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public DateTime UpdatedAt { get; set; } = DateTime.Now;

        public virtual ICollection<Track> Tracks { get; set; }
        public virtual User.User User { get; set; }
    }
}