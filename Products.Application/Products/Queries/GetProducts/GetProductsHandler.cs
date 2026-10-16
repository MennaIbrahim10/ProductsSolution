using Products.Application.DTOs;
using Products.Application.Interfaces;

namespace Products.Application.Products.Queries.GetProducts;

public class GetProductsHandler(IProductRepository repository)
{
    public async Task<IEnumerable<ProductDto>> Handle(GetProductsQuery query)
    {
        return await repository.GetProductsAsync();
    }
}
