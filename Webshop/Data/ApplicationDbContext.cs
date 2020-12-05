using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Webshop.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Models.Product> Products { get; set; }
        public DbSet<Models.Customer> Customers { get; set; }
        public DbSet<Models.Order> Orders { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Models.Product>(entity =>
            {
                entity.Property(x => x.Name).IsRequired();
                entity.Property(x => x.Price).IsRequired();
                entity.Property(x => x.Quantity).IsRequired();
                entity.Property(x => x.ImageUrl);
                entity.Property(x => x.Description).IsRequired();

            });

            builder.Entity<Models.Product>().HasData(
                new Models.Product()
                {
                    Id = 1,
                    Name = "Falselash F100",
                    Price = 60,
                    Quantity = 10,
                    ImageUrl = @"/Images/MinklashF100.jpg",
                    Description = "Falselash made of faux mink, cruelty free."
                },

                new Models.Product()
                {
                    Id = 2,
                    Name = "Longlash F200",
                    Price = 70,
                    Quantity = 15,
                    ImageUrl = @"/Images/LonglashF200.jpg",
                    Description = "Falselash made of faux mink, cruelty free."
                },
                
                new Models.Product()
                {
                    Id = 3,
                    Name = "Double pack of long falselashes",
                    Price = 150,
                    Quantity = 20,
                    ImageUrl = @"/Images/MinklashDouble.jpg",
                    Description = "Double pack of falsies, made of faux mink. Cruelty free."
                },
                
                new Models.Product()
                { 
                Id = 4,
                Name = "Stella Lashes",
                Price = 95,
                Quantity = 100,
                ImageUrl = @"/Images/StellaLashes.png",
                Description = "Long natural lashes."
                },
                
                new Models.Product()
                { 
                    Id = 5,
                    Name = "Individual lashes",
                    Price = 200,
                    Quantity = 50,
                    ImageUrl = @"/Images/Individuals.png",
                    Description = "Individual lashes, glue not included"
                },
                
                new Models.Product()
                { 
                Id = 6,
                Name = "Duo Lash Adhesive",
                Price = 100,
                Quantity = 40,
                ImageUrl = @"/Images/DuoLashAdhesive.png",
                Description = "Adhesive for falselashes, not permanent."
                });

        }
    }
}
