using _05___Decorator.Pizza.ComponentBase;

namespace _05___Decorator.Pizza.ConcreteDecorator
{
    class PineappleDecorator : ToppingDecorator
    {
        public PineappleDecorator(IPizza pizza) : base(pizza)
        {
            // Set the topping cost.
            _cost = 2.5M;
        }
    }
}
