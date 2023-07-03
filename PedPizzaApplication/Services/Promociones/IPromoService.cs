namespace PedPizzaApplication.Services.Promociones
{
    public interface IPromoService
    {
        void RegistrarPromocion(string nombre, int descuento, int dia, int concepto);
    }
}
