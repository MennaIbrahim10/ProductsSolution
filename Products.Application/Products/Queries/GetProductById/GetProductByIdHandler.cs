using Products.Application.DTOs;
using Products.Application.Interfaces;

namespace Products.Application.Products.Queries.GetProductById;

public class GetProductByIdHandler(IProductRepository repository)
{
    public async Task<ProductDto?> Handle(GetProductByIdQuery query)
    {
        return await repository.GetProductByIdAsync(query.Id);
    }
}