using System.ComponentModel.DataAnnotations;

namespace PedPizzaApplication.Models
{
    public class Pedido
    {
        [Key]
        public int Id { get; set; }
        public string Nombre { get; set; }
        public DateTime Fecha { get; set; }
        public int PromocionId { get; set; }
    }
}
