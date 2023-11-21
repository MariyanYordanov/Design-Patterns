namespace DesignPatterns
{
    // Builder Pattern
    public class ProductBuilder
    {
        private Product product = new Product();

        public ProductBuilder WithName(string name)
        {
            product.Name = name;
            return this;
        }

        public ProductBuilder WithPrice(decimal price)
        {
            product.Price = price;
            return this;
        }

        public Product Build()
        {
            return product;
        }
    }
}
