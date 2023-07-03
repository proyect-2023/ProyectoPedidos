using System.ComponentModel.DataAnnotations;

namespace PedPizzaApplication.Models
{
    public class DetallePedido
    {
        [Key]
        public int Id { get; set; }
        public int PedidoId { get; set;}
        public int Producto { get; set;}
        public int Cantidad { get; set; }
        public decimal Importe { get; set; }
        public decimal ImporteDescuento { get; set; }
    }
}
