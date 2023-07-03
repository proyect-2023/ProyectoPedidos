using PedPizzaApplication.Models;
using PedPizzaApplication.Models.ProdPizza;
using System.Security.Cryptography;

namespace PedPizzaApplication.Services.Produccion
{
    public class ProduccionService : IProduccionService
    {
       // private readonly Preparador _preparador;
        private readonly AppDbContext _appDbContext;

        public ProduccionService(AppDbContext appDbContext)
        {
          //  _preparador = preparador;
            _appDbContext = appDbContext;
        }
        public Pizza CrearPizza(int tipo)
        {
            Preparador _preparador= new Preparador();
            string nombrePizza = string.Empty;
            decimal precio;

            switch (tipo) 
            { 
                case 1:
                    _preparador.PrepararPizza(new AmericanaBuilder("Familiar"));
                    nombrePizza = "Pizza Americana";
                    precio = 40;
                    break;
                case 2:
                    _preparador.PrepararPizza(new NapolitanaBuilder("Familiar"));
                    nombrePizza = "Pizza Napolitana";
                    precio = 50;
                    break;
                default: throw new ArgumentException("No existe el tipo");
            };

            _preparador.CocinarPizzaPasoAPaso();
            Pizza pizzaCreada = _preparador.PizzaPreparada;

            _ = _appDbContext.producto.Add(entity: new Producto() { Nombre=nombrePizza,Precio=precio,Concepto=2 });
            _appDbContext.SaveChanges();

            return pizzaCreada;
        }
    }
}
