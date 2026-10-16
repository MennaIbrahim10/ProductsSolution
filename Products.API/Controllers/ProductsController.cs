using Microsoft.AspNetCore.Mvc;
using Products.Application.DTOs;
using Products.Application.Products.Commands.CreateProduct;
using Products.Application.Products.Queries.GetProductById;
using Products.Application.Products.Queries.GetProducts;

namespace Products.API.Controllers;

[ApiController]
[Route("api/products")]
public class ProductsController(GetProductsHandler getProductsHandler, GetProductByIdHandler getProductByIdHandler, CreateProductHandler createProductHandler) : ControllerBase
{
   
    [HttpGet]
    public async Task<IActionResult> GetAll()
    {
        var products = await getProductsHandler.Handle( new GetProductsQuery());

        return Ok(products);
    }


    [HttpGet("{id:int}")]
    public async Task<IActionResult> GetById(int id)
    {
        var product = await getProductByIdHandler.Handle(new GetProductByIdQuery(id));

        if (product is null)
            return NotFound();

        return Ok(product);
    }


    [HttpPost]
    public async Task<IActionResult> Create(CreateProductDto dto)
    {
        var product = await createProductHandler.Handle(new CreateProductCommand(dto));

        return CreatedAtAction( nameof(GetById),new { id = product.Id },product);
    }
}