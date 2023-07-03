namespace PedPizzaApplication.Models.ProdPizza
{
    public abstract class PizzaBuilder
    {
        protected Pizza _pizza;
        public string Tamano { get; set; }
        public Pizza DevolverPizza() { return _pizza; }

        public virtual void PasoPrepararMasa()
        {

        }

        public virtual void PasoAñadirSalsa()
        {

        }

        public virtual void PasoPrepararRelleno()
        {

        }



    }
}
