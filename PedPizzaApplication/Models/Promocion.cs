using System.Security.Cryptography;

namespace PedPizzaApplication.Models
{
    public class Promocion
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public int Descuento { get; set; }
        public int Dia { get; set; }
        public int TipoConcepto { get; set; } // 1=Delivery,2=Pizza 

        public Promocion(int id, string nombre, int descuento, int dia, int tipoId)
        {
            Id = id;
            Nombre = nombre;
            Descuento = descuento;
            Dia = dia;
            TipoConcepto = tipoId;
        }

        public Promocion()
        {
            Id = 0;
            Nombre = string.Empty;
            Descuento = 0;
            Dia = 0;
            TipoConcepto = 0;
        }
    }
}
