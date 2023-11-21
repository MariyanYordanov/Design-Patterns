namespace DesignPatterns
{
    // Factory Pattern
    public class ProductFactory
    {
        public Product CreateProduct(string name, decimal price)
        {
            return new Product 
            { 
                Name = name, 
                Price = price 
            };
        }
    }
}
