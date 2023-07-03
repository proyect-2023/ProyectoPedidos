using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PedPizzaApplication.Models.ProdPizza;
using PedPizzaApplication.Services.Produccion;
using PedPizzaApplication.Services.Promociones;

namespace PedPizzaApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PizzaController : ControllerBase
    {
        private readonly IProduccionService _produccionService;

        public PizzaController(IProduccionService produccionService)
        {
            _produccionService = produccionService;
        }

        [Route("crearPizza")]
        [HttpPost]
        public IActionResult CrearPizza(int tipoPiza)
        {
            Pizza pizza=_produccionService.CrearPizza(tipoPiza);

            return Ok(pizza);
        }
    }
}
