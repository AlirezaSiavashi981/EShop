using AutoMapper;
using EShop.Application.Dtos.Product;
using EShop.Domain.Entities;
namespace EShop.Common.Helpers.AutoMappers;

public class ProductMapper : Profile
{
    public ProductMapper(Profile profile)
    {
        profile.CreateMap<Product, GetProductListDto>().ReverseMap();
        profile.CreateMap<CreateProductDto, Product>();
        profile.CreateMap<EditProductDto, Product>();
    }
}
