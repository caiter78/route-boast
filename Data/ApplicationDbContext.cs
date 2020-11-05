using Data.Entities.Route;
using Data.Entities.User;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class ApplicationDbContext: IdentityDbContext<User, Role, int>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {}
        
        public DbSet<Route> Routes { get; set; }
        public DbSet<Track> Tracks { get; set; }
        public DbSet<Waypoint> Waypoints { get; set; }

    }
}