using System;
using Software.Design.Models;
using Xunit;

namespace software.design.tests;

public class ProductTests
{
    [Fact]
    public void Product_WithInvalidInput_ThrowsAnException()
    {
        var productDTO = new ProductDTO
        {
            Name = "myTestingName",
            ManufacturerId = 1,
            Quantity = -1
        };

        Assert.Throws<ArgumentException>(() =>
            new Product(productDTO));
    }

    [Fact]
    public void Product_WithValidInput_HaveCorrectProperties()
    {
        var productDTO = new ProductDTO
        {
            Name = "Test name 2",
            ManufacturerId = 2,
            Quantity = 10
        };

        var product = new Product(productDTO);

        Assert.Equal(productDTO.Quantity, product.Quantity);
        Assert.Equal(productDTO.Name, product.Name);
        Assert.Equal(productDTO.ManufacturerId, product.ManufacturerId);
        Assert.NotNull(product.Id);
        Assert.NotNull(product.CreatedDate);
        Assert.Null(product.ModifiedDate);

    }
}