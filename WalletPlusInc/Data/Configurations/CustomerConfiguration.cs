using Microsoft.EntityFrameworkCore;
using WalletPlusInc.Data.Entities;

namespace WalletPlusInc.Data.Configurations
{
    
        public static class CustomerConfiguration
        {
            public static ModelBuilder Build(ModelBuilder modelBuilder)
            {
                modelBuilder.Entity<Customer>().Property(c => c.FirstName).IsRequired(true).HasMaxLength(100).HasColumnName("first_name");
                modelBuilder.Entity<Customer>().Property(c => c.LastName).IsRequired(true).HasMaxLength(100);
                modelBuilder.Entity<Customer>().Property(c => c.MiddleName).IsRequired(true).HasMaxLength(100);
                modelBuilder.Entity<Customer>().Property(c => c.Country).HasMaxLength(50);
                modelBuilder.Entity<Customer>().Property(c => c.State).HasMaxLength(56);
                modelBuilder.Entity<Customer>().Property(c => c.City).HasMaxLength(56);
            //modelBuilder.Entity<Customer>().HasIndex(c => c.PhoneNumber).IsUnique();
            //modelBuilder.Entity<Customer>().HasIndex(c => c.Email).IsUnique();

            return modelBuilder;
            }
        }
    }

