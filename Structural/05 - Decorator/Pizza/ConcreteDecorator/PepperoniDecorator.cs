using _05___Decorator.Pizza.ComponentBase;

namespace _05___Decorator.Pizza.ConcreteDecorator
{
    class PepperoniDecorator : ToppingDecorator
    {
        public PepperoniDecorator(IPizza pizza) : base(pizza)
        {
            // Set the topping cost.
            _cost = 4;
        }
    }
}
