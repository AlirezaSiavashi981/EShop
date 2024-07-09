using AutoMapper;
using EShop.Application.Dtos.Product;
using EShop.Infrastructure.Repositories.Implementations;

namespace EShop.Application.Services.Product;

public class ProductService(ProductRepository productRepository, IMapper mapper)
{
    public async Task<IEnumerable<GetProductListDto>> List(CancellationToken ct)
    {
        var list = await productRepository.GetAllAsync(ct);

        var products = mapper.Map<IEnumerable<GetProductListDto>>(list);

        return products;
    }
}
