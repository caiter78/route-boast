using Data.Entities.Route;
using Microsoft.EntityFrameworkCore;

namespace Data
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Waypoint>()
                .HasOne(w => w.Track)
                .WithMany(t => t.Waypoints);
            modelBuilder.Entity<Route>()
                .HasOne(r => r.User)
                .WithMany(u => u.Routes);
        }
        
        public DbSet<Route> Routes { get; set; }
        public DbSet<Track> Tracks { get; set; }
        public DbSet<Waypoint> Waypoints { get; set; }

    }
}