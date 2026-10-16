using Products.Application.DTOs;
using Products.Domain.Entities;

namespace Products.Application.Interfaces;

public interface IProductRepository
{
    Task<IEnumerable<ProductDto>> GetProductsAsync();

    Task<ProductDto?> GetProductByIdAsync(int id);

    Task<ProductDto> AddProductAsync(Product product);
}