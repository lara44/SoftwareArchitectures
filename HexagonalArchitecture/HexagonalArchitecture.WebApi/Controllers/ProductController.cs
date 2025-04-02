
using HexagonalArchitecture.Core.Application.Services.Product.CreateProduct;
using HexagonalArchitecture.Core.Application.Services.ProductService.Interfaces;
using Microsoft.AspNetCore.Mvc;


namespace HexagonalArchitecture.WebApi.Controllers
{
    [ApiController]
    [Route("hexagonal/api/productos")]
    public class ProductController : ControllerBase
    {
        private readonly ICreateProductHandler _createProductHandler;
        public ProductController(
            ICreateProductHandler createProductHandler
        )
        {
            _createProductHandler = createProductHandler;
        }
        [HttpPost]
        public async Task<IActionResult> CrearProducto([FromBody] CreateProduct createProduct)
        {
            await _createProductHandler.Execute(createProduct);
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