using System;
namespace ProductPricings.Model.ResponseModol;

public class ProductReponse
{
    public string Id { get; set; } = "";
    public string Code { get; set; } = "";
    public string? Name { get; set; }
    public string Category { get; set; } = "";
}

