
using Microsoft.AspNetCore.Mvc;


namespace HexagonalArchitecture.WebApi.Controllers
{
    [ApiController]
    [Route("hexagonal/api/productos")]
    public class ProductController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> CrearProducto()
        {
            await Task.CompletedTask;
            return Ok();
        }
        [HttpGet]
        public async Task<IActionResult> ObtenerProductos()
        {
            var productos = new List<string> { "Producto1", "Producto2", "Producto3" };
            await Task.CompletedTask;
            return Ok(productos);
        }
    }
}