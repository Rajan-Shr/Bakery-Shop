using Microsoft.EntityFrameworkCore;
using Bakery.Data;

namespace Bakery.Model
{
    public class BakeryContext : DbContext
    {
        public DbSet<Product> Products { get; set; }

        public BakeryContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductConfiguration()).Seed();
        }
    }

}
