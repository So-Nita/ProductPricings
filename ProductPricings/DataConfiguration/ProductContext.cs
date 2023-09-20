using System;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using ProductPricings.Model.Product;

namespace ProductPricings.DataConfiguration;

public class ProductContext : DbContext
{
    public ProductContext(DbContextOptions options) : base(options)
    {

    }
    public DbSet<Product> Products { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}

