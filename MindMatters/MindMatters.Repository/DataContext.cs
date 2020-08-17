using Microsoft.EntityFrameworkCore;
using MindMatters.DomainModel.Service;
using System;
using System.Collections.Generic;
using System.Text;

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
        public DbSet<Service> Services { get; set; }

        // This line lets us override the default behaviour of EF when it creates to table, which will create the table names
        // to match the property names above. This time we will override so the names are not plural
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Service>().ToTable("Service");
        }
    }
}
