
using ATCMediator.Mediator;
using HexagonalArchitecture.Application.Services.Product.GetProductAll;
using HexagonalArchitecture.Core.Application.Services.Product.CreateProduct;
using Microsoft.AspNetCore.Mvc;

namespace HexagonalArchitecture.WebApi.Controllers
{
    [ApiController]
    [Route("hexagonal/api/productos")]
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductController(
            IMediator mediator
        )
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> CrearProducto([FromBody] CreateProductCommand createProduct)
        {
            await _mediator.SendCommand(createProduct);
            return Ok();
        }
        [HttpGet]
        public async Task<IActionResult> ObtenerProductos()
        {
            var productos = await _mediator.SendQuery(new GetProductAllQuery());
            return Ok(productos);
        }
    }
}