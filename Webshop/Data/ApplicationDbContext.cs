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
                    ImageUrl = @" ",
                    Description = "Falselash made of faux mink, cruelty free."
                });

        }
    }
}
