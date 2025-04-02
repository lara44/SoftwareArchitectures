
namespace LayeredArchitecture.WebApi.Data.Entities
{
    public class ProductEntity
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }
    }
}