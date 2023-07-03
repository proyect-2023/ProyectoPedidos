using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PedPizzaApplication.Services.Promociones;

namespace PedPizzaApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PromocionController : ControllerBase
    {
        private readonly IPromoService _promoService;
        
        public PromocionController(IPromoService promoService)
        {
             _promoService = promoService;
        }
        [Route("registrarPromocion")]
        [HttpPost]
        public IActionResult Registrar(string nombrePromocion, int descuento, int dia,int concepto)
        {
            _promoService.RegistrarPromocion(nombrePromocion, descuento, dia,concepto);
            return Ok("Promoción Creada");
        }
    }
}
