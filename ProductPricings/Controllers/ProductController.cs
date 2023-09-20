using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProductPricings.DataConfiguration;

namespace ProductPricings.Controllers
{
    [Route("/api/ProductController")]
    public class ProductController : Controller
    {
        private readonly ProductContext _context;
        public ProductController(ProductContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var data = _context.Products.ToList();
            return Ok(data); 
        }
    }
}

