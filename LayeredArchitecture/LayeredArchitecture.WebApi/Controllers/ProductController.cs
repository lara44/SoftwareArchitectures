
using ATCMediator.Mediator.Interfaces;
using LayeredArchitecture.WebApi.Services.CreateProduct;
using LayeredArchitecture.WebApi.Services.GetProducts;
using Microsoft.AspNetCore.Mvc;

namespace LayeredArchitecture.WebApi.Controllers
{
    [ApiController]
    [Route("api/productos")]
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
        public async Task<IActionResult> CrearProducto([FromBody] CreateProductCommand producto)
        {
            await _mediator.SendCommand(producto);
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