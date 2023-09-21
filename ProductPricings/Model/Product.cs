using System;
namespace ProductPricings.Model.Product;

public class Product
{
	public string Id { get; set; } = "";
    public string Code { get; set; } = "";
    public string? Name { get; set; }
    public string Category { get; set; } = "";
    public DateTime Created { get; set; }
    public DateTime? LastUpdated { get; set; }
}

