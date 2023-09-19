using System;
using System.Reflection;
using Microsoft.EntityFrameworkCore;

namespace ProductPricings.DataConfiguration;

public class ProductContext : DbContext
{
    public ProductContext(DbContextOptions options) : base(options)
    {

    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //base.OnModelCreating(modelBuilder);
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}

