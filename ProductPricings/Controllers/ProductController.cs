using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ProductPricings.Model.Product;
using ProductPricings.Model.RequestModel;
using ProductPricings.Model.ResponseModol;
using ProductPricings.Service;

namespace ProductPricings.Controllers;

[Route("/api/ProductController")]
public class ProductController : Controller
{
    private readonly ProductSevice _service;
    private readonly IMapper _mapper;
    public ProductController(ProductSevice service, IMapper mapper)
    {
        _service = service;
        _mapper = mapper;
    }
    [HttpGet]
    public ActionResult Index()
    {
        var data = _service.GetAllProducts();
        var result = _mapper.Map<List<ProductReponse>>(data);

        return Ok(result);
    }
    [HttpPost]
    public ActionResult CreateProduct([FromBody] ProductCreateReq model)
    {
        var data = _mapper.Map<Product>(model);
        _service.Create(data);
        return Ok(data);
    }
    //[HttpPut]
    //public ActionResult UpdateProduct([FromBody] ProductUpdateReq model)
    //{
    //    var data = _mapper.Map<Product>(model);
    //    return Ok();
    //}
}

