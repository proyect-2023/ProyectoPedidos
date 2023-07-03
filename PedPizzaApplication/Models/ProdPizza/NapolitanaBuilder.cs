namespace PedPizzaApplication.Models.ProdPizza
{
    public class NapolitanaBuilder : PizzaBuilder
    {
        public NapolitanaBuilder(string tamaño)
        {
            _pizza = new Pizza { Tamano = tamaño };
        }
        public override void PasoPrepararMasa()
        {
            _pizza.Masa = "Cocido";
        }

        public override void PasoAñadirSalsa()
        {
            _pizza.Salsa = "Roquefort";
        }

        public override void PasoPrepararRelleno()
        {
            _pizza.Relleno = "mozzarela+gorgonzola+parmesano+ricotta";
        }
    }
}
