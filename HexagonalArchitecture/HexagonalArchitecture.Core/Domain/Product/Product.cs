
namespace HexagonalArchitecture.Core.Domain.Product
{
    public sealed class Product
    {
        public Guid Id { get; init; }
        public string? Name { get; private set; }
        public decimal Price { get; private set; }

        private Product(Guid Id, string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public static Product Create(string name, decimal price)
        {
            return new Product(Guid.NewGuid(), name, price);
        }
    }
}