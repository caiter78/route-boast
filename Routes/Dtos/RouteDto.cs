using System;

namespace Routes.Dtos
{
    public class RouteDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public int LikeCount { get; set; }
        public DateTime UpdatedAt { get; set; }
    }
}