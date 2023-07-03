namespace PedPizzaApplication.Models.ProdPizza
{
    public class AmericanaBuilder : PizzaBuilder
    {
        public AmericanaBuilder(string tamaño)
        {
            _pizza = new Pizza { Tamano = tamaño };
        }
        public override void PasoPrepararMasa()
        {
            _pizza.Masa = "Suave";
        }

        public override void PasoAñadirSalsa()
        {
            _pizza.Salsa = "Dulce";
        }

        public override void PasoPrepararRelleno()
        {
            _pizza.Relleno = "piña+tomate+jamón";
        }
    }
}
