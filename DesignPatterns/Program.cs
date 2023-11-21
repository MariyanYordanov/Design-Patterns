namespace DesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Factory Pattern");

            ProductFactory factory = new();

            Product productA = factory.CreateProduct("Product A", 10.99m);
            Product productB = factory.CreateProduct("Product B", 24.99m);

            Console.WriteLine($"Product 1: {productA.Name}, Price: {productA.Price:C}");
            Console.WriteLine($"Product 2: {productB.Name}, Price: {productB.Price:C}");

            Console.WriteLine();
            Console.WriteLine("ObjectMother Pattern");

            ProductObjectMother objectMother = new();

            Product expensiveProduct = objectMother.CreateExpensiveProduct();
            Product affordableProduct = objectMother.CreateAffordableProduct();

            Console.WriteLine($"Expensive Product: {expensiveProduct.Name}, Price: {expensiveProduct.Price:C}");
            Console.WriteLine($"Affordable Product: {affordableProduct.Name}, Price: {affordableProduct.Price:C}");

            Console.WriteLine();
            Console.WriteLine("Builder Pattern");
            Product expensiveBuilderProduct = new ProductBuilder()
               .WithName("Expensive Product")
               .WithPrice(99.99m)
               .Build();

            Product affordableBuilderProduct = new ProductBuilder()
                .WithName("Affordable Product")
                .WithPrice(19.99m)
                .Build();

            Console.WriteLine($"Expensive Product create with Builder Pattern: {expensiveBuilderProduct.Name}, Price: {expensiveBuilderProduct.Price:C}");
            Console.WriteLine($"Affordable Product create with Builder Pattern: {affordableBuilderProduct.Name}, Price: {affordableBuilderProduct.Price:C}");
        }
    }
}