using Products.Application.DTOs;
using Products.Application.Interfaces;
using Products.Domain.Entities;

namespace Products.Application.Products.Commands.CreateProduct;

public class CreateProductHandler(IProductRepository repository)
{
    public async Task<ProductDto> Handle(CreateProductCommand command)
    {
        var product = new Product
        {
            Name = command.Product.Name,
            Price = command.Product.Price
        };

        return await repository.AddProductAsync(product);
    }
}