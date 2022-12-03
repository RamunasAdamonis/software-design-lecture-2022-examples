namespace Software.Design.Models;

public class Product
{
    private string _name = default!;
    private int _quantity = default!;

    private Product()
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
    public string Name
    {
        get => _name;
        private set
        {
            ValidateName(value);
            _name = value;
        }
    }

    public int Quantity
    {
        get => _quantity;
        private set
        {
            ValidateQuantity(value);
            _quantity = value;
        }
    }

    public int ManufacturerId { get; private set; }

    private void ValidateName(string name)
    {
        const int maxNameLength = 64;

        if (name.Length > maxNameLength)
            throw new ArgumentException($"Name cannot be longer then {maxNameLength} characters");
    }

    private void ValidateQuantity(int quantity)
    {
        const int maxQuantity = 5000;

        if (quantity <= 0)
            throw new ArgumentException($"Quantity cannot be zero or negative");

        if (quantity > maxQuantity)
            throw new ArgumentException($"Quantity cannot be grater than {maxQuantity}");
    }

}