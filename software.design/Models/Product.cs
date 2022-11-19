namespace Software.Design.Models;

public class Product
{
    public Product()
    {
    }

    public Product(ProductDTO productDTO)
    {
        Id = Guid.NewGuid();
        CreatedDate = DateTime.UtcNow;
        ModifiedDate = null;
        Name = productDTO.Name;
        Quantity = productDTO.Quantity;
        ManufacturerId = productDTO.ManufacturerId;
    }

    public Guid Id { get; private set; }
    public DateTime CreatedDate { get; private set; }
    public DateTime? ModifiedDate { get; private set; }
    public string Name { get; private set; } = default!;
    public int Quantity { get; private set; }
    public int ManufacturerId { get; private set; }
}