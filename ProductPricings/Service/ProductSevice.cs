using System;
using ProductPricings.DataConfiguration;
using ProductPricings.Model.Product;
using ProductPricings.Repository;

namespace ProductPricings.Service
{
	public class ProductSevice
	{
        private readonly Repository<Product> _context;
		public ProductSevice(Repository<Product> context)
		{
            _context = context;
		}
		public List<Product> GetAllProducts()
		{
			var data = _context.GetAll()!.ToList();
            return data;
		}
        
        public void Create(Product product)
        {
            if (product == null) throw new ArgumentNullException(nameof(product));
            if (string.IsNullOrEmpty(product.Code)) throw new ArgumentException("Code is required");
            if (string.IsNullOrEmpty(product.Category)) throw new ArgumentException("Category is required");
            try
            {
                _context.Add(product);
                _context.SaveChanges();
            }catch
            {
                throw new Exception();
            }
        }
    }
}

