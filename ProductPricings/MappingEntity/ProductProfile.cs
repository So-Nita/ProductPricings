using System;
using AutoMapper;
using ProductPricings.Model.Product;
using ProductPricings.Model.RequestModel;
using ProductPricings.Model.ResponseModol;

namespace ProductPricings.MappingEntity;

public class ProductProfile : Profile
{
	public ProductProfile()
    { 
        CreateMap<Product, ProductReponse>();
        CreateMap<ProductCreateReq, Product>()
            .ForMember(e => e.Id, opt => opt.MapFrom(e => Guid.NewGuid().ToString()))
            .ForMember(e=>e.Created,opt=>opt.MapFrom(e=> DateTime.Now));
        //CreateMap<ProductUpdateReq, Product>()
        //    .ForMember(e => e.Code, opt => opt.MapFrom(e => e.Code == "" || e.Code == "string"));
    }
}

