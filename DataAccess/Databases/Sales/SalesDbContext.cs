using DataAccess.Entities;
using Infrastructure.Extensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace DataAccess.Databases.Sales
{
    public class SalesDbContext : DbContext
    {

        public SalesDbContext([NotNull] DbContextOptions options) : base(options)
        {
        }

        public DbSet<Customer> Customers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.HasDefaultSchema("sales");
            var customer = modelBuilder.Entity<Customer>();

            customer.HasKey(x => x.Id).IsClustered(false);
            customer.Property(x => x.Id).ValueGeneratedOnAdd();
            customer.Property(x => x.CreatedOn).NewDateAutoInsertedOnCreate();
            customer.Property(x => x.UpdatedOn).NewDateAutoInsertedOnCreate();
        }
    }
}
