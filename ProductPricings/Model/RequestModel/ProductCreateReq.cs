using System;
namespace ProductPricings.Model.RequestModel
{
	public class ProductCreateReq
	{
        public string Code { get; set; } = "";
        public string? Name { get; set; }
        public string Category { get; set; } = "";
    }
}

