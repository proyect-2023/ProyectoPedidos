using PedPizzaApplication.Models;

namespace PedPizzaApplication.Services.Pedidos
{
    public interface IPedidoService
    {
        object CrearPedido(string nombre, List<DetalleItem> detalle);
    }
}
