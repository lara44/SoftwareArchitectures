
using HexagonalArchitecture.Application.Services.Product.CreateProduct;
using HexagonalArchitecture.Application.Services.Product.GetProductAll;
using HexagonalArchitecture.Core.Application.Services.Product.CreateProduct;
using Microsoft.AspNetCore.Mvc;

namespace HexagonalArchitecture.WebApi.Controllers
{
    [ApiController]
    [Route("hexagonal/api/productos")]
    public class ProductController : ControllerBase
    {
        private readonly ICreateProductCommandHandler _createProductCommandHandler;
        private readonly IGetProductAllQuery _getProductAllQuery;
        public ProductController(
            ICreateProductCommandHandler createProductHandler,
            IGetProductAllQuery getProductAllQuery
        )
        {
            _createProductCommandHandler = createProductHandler;
            _getProductAllQuery = getProductAllQuery;
        }
        [HttpPost]
        public async Task<IActionResult> CrearProducto([FromBody] CreateProductCommand createProduct)
        {
            await _createProductCommandHandler.Execute(createProduct);
            return Ok();
        }
        [HttpGet]
        public async Task<IActionResult> ObtenerProductos()
        {
            var productos = await _getProductAllQuery.Execute();
            return Ok(productos);
        }
    }
}