
using LayeredArchitecture.WebApi.Entities;
using LayeredArchitecture.WebApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LayeredArchitecture.WebApi.Controllers
{
    [ApiController]
    [Route("api/productos")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(
            IProductService productService
        )
        {
            _productService = productService;
        }

        [HttpPost]
        public async Task<IActionResult> CrearProducto([FromBody] Product producto)
        {
            await _productService.CrearProductoAsync(producto.Name!, producto.Price);
            return Ok();
        }
        [HttpGet]
        public async Task<IActionResult> ObtenerProductos()
        {
            var productos = await _productService.ObtenerProductosAsync();
            return Ok(productos);
        }
    }
}