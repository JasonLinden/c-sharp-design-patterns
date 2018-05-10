using _05___Decorator.Pizza.ComponentBase;

namespace _05___Decorator.Pizza.ConcreteDecorator
{
    class OlivesDecorator : ToppingDecorator
    {
        public OlivesDecorator(IPizza pizza) : base(pizza)
        {
            // Set the topping cost.
            _cost = 1.5M;
        }
    }
}
