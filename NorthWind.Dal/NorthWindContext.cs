using Microsoft.EntityFrameworkCore;
using NorthWind.Entities;

namespace NorthWind.Dal
{
    public class NorthWindContext : DbContext
    {
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }

        public NorthWindContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                    .UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=NorthwindPoc;Trusted_Connection=true;");
            }
        }
    }
}