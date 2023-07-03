using System.ComponentModel.DataAnnotations;

namespace PedPizzaApplication.Models
{
    public class Producto
    {
        [Key]
        public int Id { get; set; } 
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Concepto { get; set; } // 1=Delivery,2=Pizza 
    }
}
