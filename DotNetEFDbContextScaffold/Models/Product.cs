namespace DotNetEFDbContextScaffold.Models;

public class Product
{
    public long ProductId { get; set; }

    public long CategoryId { get; set; }

    public string ProductName { get; set; } = null!;

    public int Price { get; set; }

    public int Quantity { get; set; }

    public bool IsActive { get; set; }

    public Category Category { get; set; } = null!;
}