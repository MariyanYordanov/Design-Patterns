namespace DesignPatterns
{
    // Object Mother Pattern
    public class ProductObjectMother
    {
        public Product CreateExpensiveProduct()
        {
            return new Product 
            { 
                Name = "Expensive Product", 
                Price = 99.99m 
            };
        }

        public Product CreateAffordableProduct()
        {
            return new Product 
            { 
                Name = "Affordable Product", 
                Price = 19.99m 
            };
        }
    }
}
