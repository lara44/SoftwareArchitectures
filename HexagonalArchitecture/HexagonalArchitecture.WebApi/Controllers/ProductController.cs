
using ATCMediator.Mediator.Interfaces;
using HexagonalArchitecture.Application.Services.Product.GetProductAll;
using HexagonalArchitecture.Core.Application.Services.Product.CreateProduct;
using Microsoft.AspNetCore.Mvc;

namespace HexagonalArchitecture.WebApi.Controllers
{
    [ApiController]
    [Route("hexagonal/api/productos")]
    public class ProductController : ControllerBase
    {
        private readonly IAtcMediator _mediator;

        public ProductController(
            IAtcMediator mediator
        )
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CrearProducto([FromBody] CreateProductCommand createProduct)
        {
            await _mediator.ExecuteAsync(createProduct);
            return Ok();
        }
        [HttpGet]
        public async Task<IActionResult> ObtenerProductos()
        {
            var productos = await _mediator.ExecuteAsync(new GetProductAllQuery());
            return Ok(productos);
        }
    }
}