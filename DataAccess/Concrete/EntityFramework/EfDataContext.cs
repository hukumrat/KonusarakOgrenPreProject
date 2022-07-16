using Entities.Concrete;
using KonusarakOgrenPreProject.Areas.Admin.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfDataContext : IdentityDbContext
    {
        public EfDataContext(DbContextOptions<EfDataContext> options) : base(options)
        {
            
        }
        public DbSet<Comment>? Comments { get; set; }
        public DbSet<Photo>? Photos { get; set; }
        public DbSet<Product>? Products { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.EnableSensitiveDataLogging();
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();
        }
    }
}
