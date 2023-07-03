using PedPizzaApplication.Models;

namespace PedPizzaApplication.Services.Promociones
{
    public class PromoService : IPromoService
    {
        private readonly AppDbContext _appDbContext;

        public PromoService(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public void RegistrarPromocion(string nombre, int descuento, int dia,int concepto)
        {
            _ = _appDbContext.promocion.Add(entity: new Promocion() { Descuento = descuento, Nombre = nombre, Dia = dia,TipoConcepto=concepto });
            _appDbContext.SaveChanges();
        }
    }
}
