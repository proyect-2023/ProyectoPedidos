using PedPizzaApplication.Models;
using PedPizzaApplication.Services.Pedidos;
using PedPizzaApplication.Services.Produccion;
using PedPizzaApplication.Services.Promociones;

namespace PedPizzaApplication
{
    public static class Extensions
    {
        public static void ConfigureServices(this IServiceCollection services,
       IConfiguration configuration)
        {
            services.AddScoped<IPromoService, PromoService>();
            services.AddScoped<IProduccionService, ProduccionService>();
            services.AddScoped<IPedidoService, PedidoService>();

            AppDbContext data = new AppDbContext();
            services.AddSingleton(data);
        }
    }
}
