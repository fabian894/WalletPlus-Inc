using Microsoft.EntityFrameworkCore;
using WalletPlusInc.Data.Configurations;
using WalletPlusInc.Data.Entities;

namespace WalletPlusInc.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Country> Countries { get; set; }
        public DbSet<Customer> Customers { get; set; }

        public DbSet<City> Cities { get; set; }

        public DbSet<State> States { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            CustomerConfiguration.Build(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }
    }
}

    
