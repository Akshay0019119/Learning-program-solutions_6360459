using System.Collections.Generic;

public class Category
{
    public int Id { get; set; }
    public string Name { get; set; }

    // Navigation property: One category has many products
    public List<Product> Products { get; set; }
}

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }

    // Foreign key relationship
    public int CategoryId { get; set; }
    public Category Category { get; set; }
}
