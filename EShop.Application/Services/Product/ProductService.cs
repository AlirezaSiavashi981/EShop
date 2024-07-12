using AutoMapper;
using EShop.Application.Dtos.Product;
using EShop.Domain.Entities;
using EShop.Infrastructure.Repositories.Implementations;

namespace EShop.Application.Services;

public class ProductService(ProductRepository productRepository, IMapper mapper)
{
    public async Task<IEnumerable<GetProductListDto>> ProductListAsync(CancellationToken ct)
    {
        var list = await productRepository.GetAllAsync(ct);

        var products = mapper.Map<IEnumerable<GetProductListDto>>(list);

        return products;
    }

    public async Task<IEnumerable<GetProductListDto>> GetProductAsync(CancellationToken ct)
    {
        var list = await productRepository.GetAllAsync(ct);

        var products = mapper.Map<IEnumerable<GetProductListDto>>(list);

        return products;
    }

    public async Task<GetProductListDto> GetProductById(int id, CancellationToken ct)
    {
        var list = await productRepository.FindAsync(id, ct);

        var products = mapper.Map<GetProductListDto>(list);

        return products;
    }

    public async Task CreateProduct(CreateProductDto productDto, CancellationToken ct)
    {
        var product = mapper.Map<CreateProductDto, Product>(productDto);

        productRepository.Add(product);
        await productRepository.SaveChagesAsync();
    }

    public async Task EditProduct(EditProductDto productDto, CancellationToken ct)
    {
        var data = mapper.Map<EditProductDto, Product>(productDto);

        productRepository.Update(data);

        await productRepository.SaveChagesAsync();
    }

    public async Task DeleteProduct(int id, CancellationToken ct)
    {
        var data = await productRepository.FindAsync(id, ct);

        productRepository.Delete(data);

        await productRepository.SaveChagesAsync();
    }
}
