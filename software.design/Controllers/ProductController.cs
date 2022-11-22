using Microsoft.AspNetCore.Mvc;
using Software.Design.Services;

namespace Software.Design.Models.Controllers;

[ApiController]
[Route("api/products")]
public class ProductController : ControllerBase
{
    private readonly ILogger<ProductController> _logger;
    private readonly ProductService _productService;


    public ProductController(
        ILogger<ProductController> logger,
        ProductService productService)
    {
        _logger = logger;
        _productService = productService;
    }

    [HttpGet]
    public async Task<ActionResult<List<Product>>> GetProducts()
    {
        var products = await _productService.GetProducts();
        return Ok(products);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<object>> GetProduct(Guid id)
    {
        return Ok();
    }

    [HttpPost]
    public async Task<ActionResult<object>> CreateProduct(ProductDTO productDTO)
    {
        var product = await _productService.Create(productDTO);
        return Created(product);
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<object>> UpdateProduct(Guid id)
    {
        return Ok();
    }

    [HttpDelete("{id}")]
    public async Task<ActionResult<object>> DeleteProduct(Guid id)
    {
        return NoContent();
    }


    private ObjectResult Created(object value)
    {
        return StatusCode(201, value);
    }
}
