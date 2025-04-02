
using HexagonalArchitecture.Core.Application.Services.Product.CreateProduct;
using HexagonalArchitecture.Core.Application.Services.Product.GetProductAll;
using HexagonalArchitecture.Core.Application.Services.ProductService.Interfaces;
using Microsoft.AspNetCore.Mvc;


namespace HexagonalArchitecture.WebApi.Controllers
{
    [ApiController]
    [Route("hexagonal/api/productos")]
    public class ProductController : ControllerBase
    {
        private readonly ICreateProductHandler _createProductHandler;
        private readonly IGetProductAllQuery _getProductAllQuery;
        public ProductController(
            ICreateProductHandler createProductHandler,
            IGetProductAllQuery getProductAllQuery
        )
        {
            _createProductHandler = createProductHandler;
            _getProductAllQuery = getProductAllQuery;
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
            var productos = await _getProductAllQuery.Execute();
            return Ok(productos);
        }
    }
}