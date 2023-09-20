using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProductPricings.Model.Product;

namespace ProductPricings.DataConfiguration;

public class ProductEntity : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.HasKey(e => e.Id);
        builder.HasIndex(e => e.Code).IsUnique();

        builder.Property(e => e.Id).IsRequired().HasColumnType("varchar").HasMaxLength(36);
        builder.Property(e => e.Code).IsRequired().HasColumnType("varchar").HasMaxLength(20);
        builder.Property(e => e.Name).IsRequired(false).HasColumnType("nvarchar").HasMaxLength(50).IsUnicode();
        builder.Property(e => e.Category).IsRequired().HasColumnType("varchar");
        builder.Property(e => e.Created).IsRequired().HasColumnType("date");
        builder.Property(e => e.LastUpdated).IsRequired(false).HasColumnType("date");
    }
}

