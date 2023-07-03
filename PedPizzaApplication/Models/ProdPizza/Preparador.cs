namespace PedPizzaApplication.Models.ProdPizza
{
    public class Preparador
    {
        private PizzaBuilder _pizzaBuilder;
        public void PrepararPizza(PizzaBuilder pizzaBuilder)
        {
            _pizzaBuilder = pizzaBuilder;
        }

        public void CocinarPizzaPasoAPaso()
        {
            _pizzaBuilder.PasoPrepararMasa();
            _pizzaBuilder.PasoAñadirSalsa();
            _pizzaBuilder.PasoPrepararRelleno();
        }

        public Pizza PizzaPreparada
        {
            get { return _pizzaBuilder.DevolverPizza(); }

        }
    }
}
