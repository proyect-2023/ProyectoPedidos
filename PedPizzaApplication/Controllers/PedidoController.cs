using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PedPizzaApplication.Models;
using PedPizzaApplication.Services.Pedidos;
using PedPizzaApplication.Services.Promociones;

namespace PedPizzaApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PedidoController : ControllerBase
    {
        private readonly IPedidoService _pedidoService;
        
        public PedidoController(IPedidoService pedidoService)
        {
            _pedidoService = pedidoService;
        }
        [Route("registrarPedido")]
        [HttpPost]
        public IActionResult RegistrarPedido(string nombrePedido, List<DetalleItem> detalleItems)
        {
            var pedido = _pedidoService.CrearPedido(nombrePedido, detalleItems);


            return Ok(pedido);
        }
    }
}
