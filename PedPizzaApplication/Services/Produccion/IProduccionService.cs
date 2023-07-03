using PedPizzaApplication.Models.ProdPizza;

namespace PedPizzaApplication.Services.Produccion
{
    public interface IProduccionService
    {
        Pizza CrearPizza(int tipo);
    }
}
