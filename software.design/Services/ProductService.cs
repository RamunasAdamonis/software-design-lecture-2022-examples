using Microsoft.EntityFrameworkCore;
using Software.Design.DataModels;
using Software.Design.Models;

namespace Software.Design.Services;

public class ProductService
{
    private readonly ProductContext _dbContext;

    public ProductService(ProductContext dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<List<Product>> GetProducts()
    {
        var products = await _dbContext.Products.ToListAsync();
        return products;
    }

    public async Task<Product> Create(ProductDTO productDTO)
    {
        var product = new Product(productDTO);

        await _dbContext.Products.AddAsync(product);
        await _dbContext.SaveChangesAsync();
        return product;
    }
}