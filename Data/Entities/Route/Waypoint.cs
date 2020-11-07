using System;
using System.ComponentModel.DataAnnotations;

namespace Data.Entities.Route
{
    public class Waypoint
    {
        public long Id { get; set; }
        [Required]
        public double Lat { get; set; }
        [Required]
        public double Lon { get; set; }
        [Required]
        public DateTime Time { get; set; }
        public int Height { get; set; }    
        public virtual Track Track { get; set; }
    }
}