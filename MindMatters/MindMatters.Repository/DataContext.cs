using Microsoft.EntityFrameworkCore;
using MindMatters.DomainModel.Addresses;
using MindMatters.DomainModel.Locations;
using MindMatters.DomainModel.Services;

namespace MindMatters.Repository
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        // This code creates a DbSet for each entity set.
        // EF TERMINOLOGY:
        // Entity Set = Database table
        // Entity = row in that table
        public DbSet<Facility> Facilities { get; set; }
        public DbSet<GeoCoordinate> GeoCoordinates { get; set; }
        public DbSet<Address> Addresses { get; set; }

        // This line lets us override the default behaviour of EF when it creates to table, which will create the table names
        // to match the property names above. This time we will override so the names are not plural
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Facility>().ToTable("Service");
            modelBuilder.Entity<GeoCoordinate>().ToTable("GeoCoordinate");
            modelBuilder.Entity<Address>().ToTable("Address");
        }
    }
}
