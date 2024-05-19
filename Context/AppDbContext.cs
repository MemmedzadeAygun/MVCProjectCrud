using ComuterStoreProject.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace ComuterStoreProject.Context
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {        
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        public DbSet<Computer> Computers { get; set; }
        public DbSet<Detail> Details { get; set; }
    }
}
