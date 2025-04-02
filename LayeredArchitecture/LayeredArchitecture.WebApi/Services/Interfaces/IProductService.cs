
using LayeredArchitecture.WebApi.Data.Entities;

namespace LayeredArchitecture.WebApi.Services.Interfaces
{
    public interface IProductService
    {
        Task CrearProductoAsync(string name, decimal price);
        Task<IEnumerable<ProductEntity>> ObtenerProductosAsync();
    }
}