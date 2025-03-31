
using LayeredArchitecture.WebApi.Entities;

namespace LayeredArchitecture.WebApi.Services.Interfaces
{
    public interface IProductService
    {
        Task CrearProductoAsync(string name, decimal price);
        Task<List<Product>> ObtenerProductosAsync();
    }
}