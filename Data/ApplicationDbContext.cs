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
        }
        
        public DbSet<Route> Routes { get; set; }
        public DbSet<Track> Tracks { get; set; }
        public DbSet<Waypoint> Waypoints { get; set; }

    }
}