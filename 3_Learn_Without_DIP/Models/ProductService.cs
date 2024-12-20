using System.Collections.Generic;

public class ProductService:IDatabase
{
    private readonly IDatabase _database;

    // Constructor with a new dependency
    public ProductService(IDatabase database)
    {
        _database = database;
    }

    public List<string> GetProducts()
    {
        // Get products from the database
        return new List<string>() { "Product A", "Product B", "Product C" };
    }
}
